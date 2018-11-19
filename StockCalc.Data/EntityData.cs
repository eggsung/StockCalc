using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data
{
    public class EntityData<T> where T : class
    {

        protected static StockCalcEntities CreateContext()
        {

            var context = new StockCalcEntities();
            context.Database.Log = PrintSql;

            return context;
        }

        private static void PrintSql(String sql)
        {
            Debug.WriteLine(sql);
        }

        public int GetCount()
        {
            return CreateContext().Set<T>().Count();
        }

        public List<T> Select()
        {
            return CreateContext().Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            CreateContext().Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

    }
}
