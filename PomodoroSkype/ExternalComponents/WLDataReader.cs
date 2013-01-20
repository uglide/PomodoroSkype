using System;
using System.IO;

namespace PomodoroSkype.ExternalComponents
{
    static class WlDataReader
    {
        private const string DbDefaultPath = @"\6Wunderkinder\Wunderlist\Wunderlist.dat";

        private static Wunderkinder.Wunderlist.Data.LocalStorage.Store _store = null;


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
            var serializer = new Wunderkinder.Wunderlist.Data.LocalStorage.CompressedXmlStoreSerializer();
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

        public static Wunderkinder.Wunderlist.Business.Entities.TaskList[] GetLists()
        {
            if (null == _store)
            {
                throw new Exception("WlDb not loaded!");
            }

            return _store.Workspace.TaskListsAsArray;
        }        
        
    }
}
