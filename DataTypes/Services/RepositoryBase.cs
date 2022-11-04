using DataTypes.Interfaces;
using DataTypes.Model;
using DataTypes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Services
{
    public class RepositoryBase<T> : IRepository<T> where T : class
    {
        protected SchoolContext context;
        private IDbContextTransaction _transaction;

        public RepositoryBase()
        {
            context = new SchoolContext();
        }

        public void Begin()
        {
            this._transaction = context.Database.BeginTransaction();
        }

        public (bool, string) Commit()
        {
            try
            {
                //context.Database.CommitTransaction();
                this._transaction.Commit();
                return (true, "Success");
            }
            catch (DbException dbEx)
            {
                if (dbEx.InnerException != null)
                {
                    return (false, "Trouble happened! \n" + dbEx.Message + "\n" + dbEx.InnerException.Message);
                }
                else
                {
                    return (false, "Trouble happened! \n" + dbEx.Message);
                }
            }
        }

        public void Delete(object T)
        {
            context.Remove(T);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            var query = context.Set<T>() as IQueryable<T>;
            return query.ToList();
        }

        public T GetById<T>(long id) where T : BaseEntity
        {
            var query = context.Set<T>() as IQueryable<T>;
            query = query.Where(e => e.Id == id);

            return query.FirstOrDefault();
        }

        public void RollBack()
        {
            this._transaction.Rollback();
            //context.Database.RollbackTransaction();
        }

        public void Save(object T)
        {
            context.Add(T);
            context.SaveChanges();
        }

        public void Update(object T)
        {
            context.Update(T);
            context.SaveChanges();
        }
    }
}
