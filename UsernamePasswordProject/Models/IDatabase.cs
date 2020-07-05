﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace LocalDatabaseTutorial.Models
{
    public interface IDatabase
    {
        Task<Account> GetAccountAsync(string userName);
        Task<List<Account>> GetAccountsAsync();
        Task<int> SaveAccountAsync(Account account);
    }
}
