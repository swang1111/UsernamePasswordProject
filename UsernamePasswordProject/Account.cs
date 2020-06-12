﻿using SQLite;

namespace LocalDatabaseTutorial
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
    }
}