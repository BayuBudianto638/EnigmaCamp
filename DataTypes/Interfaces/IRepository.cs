using DataTypes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Interfaces
{
    public interface IRepository<T>
    {
        void Begin();
        void RollBack();
        (bool, string) Commit();
        void Save(object T);
        void Update(object T);
        void Delete(object T);
        List<T> GetAll();
        T GetById<T>(long id) where T: BaseEntity;
    }
}
