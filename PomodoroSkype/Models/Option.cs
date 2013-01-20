using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PomodoroSkype.Models
{
    struct OptionType
    {
        public const string Bool = "bool";
        public const string Numeric = "numeric";
        public const string Text = "text";

        public string Value { get; set; }       
    }

    class Option
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public OptionType Type { get; set; }
        public string Value { get; set; }

        public Int32 GetInt()
        {
            return Convert.ToInt32(Value);
        }
    }


}

