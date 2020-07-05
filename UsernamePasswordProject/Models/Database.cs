﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace LocalDatabaseTutorial.Models
{
    public class Database : IDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Account>().Wait();
        }

        public Task<Account> GetAccountAsync(string userName)
        {
            // var existingItem = _database.GetAsync<Account>(userName); // ? not completely sure if this is how you do it
            // return existingItem;

            return _database.Table<Account>()
                            .Where(i => i.Username == userName)
                            .FirstOrDefaultAsync();
        }

        public Task<List<Account>> GetAccountsAsync()
        {
            return _database.Table<Account>().ToListAsync();
        }

        public Task<int> SaveAccountAsync(Account account)
        {
            return _database.InsertAsync(account);
        }
    }
}