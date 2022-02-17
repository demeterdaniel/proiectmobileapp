using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using proiectmobileapp.Models;

namespace proiectmobileapp.Data
{
    public class CartiDB
    {
        readonly SQLiteAsyncConnection _database;
        public CartiDB(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Carti>().Wait();
            
        }
        public Task<List<Carti>> GetCartiAsync()
        {
            return _database.Table<Carti>().ToListAsync();
        }
        public Task<Carti> GetCartiAsync(int id)
        {
            return _database.Table<Carti>()
            .Where(i => i.ID == id)
           .FirstOrDefaultAsync();
        }
        public Task<int> SaveCartiAsync(Carti slist)
        {
            if (slist.ID != 0)
            {
                return _database.UpdateAsync(slist);
            }
            else
            {
                return _database.InsertAsync(slist);
            }
        }
        public Task<int> DeleteShopListAsync(Carti slist)
        {
            return _database.DeleteAsync(slist);


        }

        




    }
}
