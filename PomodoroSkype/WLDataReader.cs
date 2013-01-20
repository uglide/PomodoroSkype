using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WLStorage = Wunderkinder.Wunderlist.Data.LocalStorage;
using WLEntities = Wunderkinder.Wunderlist.Business.Entities;

namespace PomodoroSkype
{
    static class WlDataReader
    {
        private const string DbDefaultPath = @"\6Wunderkinder\Wunderlist\Wunderlist.dat";

        private static WLStorage.Store _store = null;


        public static bool IsWunderListInstalled()
        {
            return File.Exists(GetWlDbPath());
        }

        private static string GetWlDbPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) 
                + DbDefaultPath;
        }

        public static void LoadData()
        {
            var serializer = new WLStorage.CompressedXmlStoreSerializer();
            _store = serializer.Load(GetWlDbPath());            
        }

        public static string GetUserName()
        {
            if (null == _store)
            {
                throw new Exception("WlDb not loaded!");
            }

            return _store.User.Name;
        }

        public static WLEntities.TaskList[] GetLists()
        {
            if (null == _store)
            {
                throw new Exception("WlDb not loaded!");
            }

            return _store.Workspace.TaskListsAsArray;
        }        
        
    }
}
