using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    public class Repository
    {
        SQLiteConnection database;
        static object locker = new object();

        public Repository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Recipe>();
        }
        public IEnumerable<Recipe> GetItems()
        {
            return database.Table<Recipe>().ToList();
        }
        public Recipe GetItem(int id)
        {
            return database.Get<Recipe>(id);
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
                return database.Delete<Recipe>(id);
            }
        }
        public int SaveItem(Recipe item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
