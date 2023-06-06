using SimpleFirstApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFirstApp.Views.Logins
{
    public class AccountAsyncRepository
    {
        SQLiteAsyncConnection database;

        public AccountAsyncRepository(string databasePath)
        {
            database = new SQLiteAsyncConnection(databasePath);
        }

        public async Task CreateTable()
        {
            await database.CreateTableAsync<Account>();
            await database.CreateTableAsync<RelatedObject>();
        }
        public async Task<List<RelatedObject>> GetItemsAsync() // неправильна функція
        {
            return await database.Table<RelatedObject>().ToListAsync();
        }
        public async Task<int> SaveRelatedObjectItemAsync(RelatedObject item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
        // end
        public async Task<List<Account>> GetAccountItemsAsync()
        {
            return await database.Table<Account>().ToListAsync();
        }
        public async Task<Account> GetItemAsync(int id)
        {
            return await database.GetAsync<Account>(id);
        }
        public async Task<int> DeleteItemAsync(Account item)
        {
            return await database.DeleteAsync(item);
        }
        public async Task<int> SaveItemAsync(Account item)
        {
            if (item.Id != 0)
            {
                await database.UpdateAsync(item);
                return item.Id;
            }
            else
            {
                return await database.InsertAsync(item);
            }
        }
    }
}
