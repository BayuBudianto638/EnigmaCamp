using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public interface IFeline
    {
        void JenisKucing(string jenisKucing);
        void Makan();
        void Tidur();
        void BAB();
    }
}
