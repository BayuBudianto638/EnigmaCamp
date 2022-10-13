using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Core
{
    public interface IStudent
    {
        Task<string> addNew();
        Task<string> remove();
        Task<string> update();
        Task<string> getAll();
    }
}
