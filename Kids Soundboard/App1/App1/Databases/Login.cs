using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Databases
{

    public class Login
    {
        // Variables
        string path;
        SQLiteConnection conn;

        public Login()
        {
            // Creating SQLite Database for user login information
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,
                "MyDB.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //Create Table
            conn.CreateTable<User>();
        }

        public int Register(User user)
        {
            int code = 1;
            // Insert user info into a new user
            // If user enters correct info into all fields code will stay at 1
            try
            {
                conn.Insert(new User()
                {
                    UserName = user.UserName,
                    Password = user.Password,
                    Email = user.Email
                });
            }
            // Otherwise will catch and change to -1
            catch (SQLiteException e)
            {
                code = -1;
            }
            return code;
        }

        // Boolean to check if username and password is true or false
        public bool LoginUser(string user, string password)
        {
            // Checking username and password
            var query = conn.Table<User>().Where(s => s.UserName == user && s.Password == password);
            if (query.Count() > 0)
                return true;
            else
                return false;
        }
    }
}
