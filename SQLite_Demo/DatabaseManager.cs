using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLite_Demo
{
    public static class DatabaseManager
    {
        //YOUR CLASS NAME MUST BE YOUR TABLE NAME
        public static SQLiteConnection db;
        public static string databasePath;
        public static string databaseName;

        static DatabaseManager()
        {//Using Xamarin Essentials to set the path. AppdataDirectory gets backed up by Android
            databaseName = "ToDoList.db";
            databasePath = Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, databaseName);
            //  if (databasePath != null)
            //  {
            db = new SQLiteConnection(databasePath);
            //   }
            // Initializes a new instance of the Database. if the database doesn't exist, it will create the database and all the tables. This is important even if you have a table a table
            db.CreateTable<tblToDo>();
        }

        public static List<tblToDo> ViewAll()
        {

        }
    }
}