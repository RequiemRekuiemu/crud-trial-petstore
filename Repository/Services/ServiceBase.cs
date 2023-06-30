using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services
{
    public class ServiceBase<T> where T : class
    {
        PetShop2023DBContext context;
        DbSet<T> dbSet;

        public ServiceBase()
        {
            context = new PetShop2023DBContext();
            dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(T entity)
        {
            try
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public void Update(T entity)
        {
            var tracker = context.Attach(entity);
            tracker.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
