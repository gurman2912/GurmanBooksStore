using Dapper;
using GurmanBook.DataAccess.Repository.IRepository;
using GurmanBooksStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GurmanBook.DataAccess.Repository
{
    class SP_Call : ISP_Call
    {
        //access the database
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = "";   //needed to called the stored procedure

        // contructor to open a SQL connection
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }

        //implements the ISP_Call interface
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
        }
    }
}
