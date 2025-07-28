using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppFit.Models;
using SQLite;

namespace MauiAppFit.Helpers
{
    public class SQLiteDataBaseHelpers
    {
        readonly SQLiteAsyncConnection _db;

        public SQLiteDataBaseHelpers(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Atividade>().Wait();
        }
    }
}
