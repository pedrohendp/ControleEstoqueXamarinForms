using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ControleEstoquePA.DataBase
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection _database;

        public DataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cliente>().Wait();
        }

        public Task<List<Cliente>> GetClientesAsync()
        {
            return _database.Table<Cliente>().ToListAsync();
        }

        public Task<int> SalvarClientesAsync(Cliente cliente)
        {
            if (cliente.Id != 0)
            {
                return _database.UpdateAsync(cliente);
            }
            else
            {
                return _database.InsertAsync(cliente);
            }
        }
    }
}
