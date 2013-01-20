using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using PomodoroSkype.ExternalComponents;

namespace PomodoroSkype.Models
{
    class SettingsManager
    {
        public Dictionary<string, Option> Options; 

        public SettingsManager()
        {
            Options = new Dictionary<string, Option>();

            LoadSettings();
        }

        public void Reload()
        {
            Options.Clear();
            LoadSettings();
        }

        private string GetAllEntitiesQuery()
        {
            return @"SELECT * FROM settings";
        }

        private void LoadSettings()
        {                
            var reader = DbHelper.Select(GetAllEntitiesQuery());

            while (reader.Read())
            {
                var option = new Option
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Type = new OptionType{Value = reader.GetString(2)},
                    Value = reader.GetString(3)
                };

                Options.Add(reader.GetString(1), option);
            }
        }

    }
}
