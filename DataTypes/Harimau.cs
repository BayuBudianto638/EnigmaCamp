using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class Harimau : IBigCats
    {
        public void BAB()
        {
            Console.WriteLine("BAB");
        }

        public void JenisKucing(string jenisKucing)
        {
            Console.WriteLine(jenisKucing);
        }

        public void Makan()
        {
            Console.WriteLine("Makan");
        }

        public void Mengaum()
        {
            Console.WriteLine("Mengaum");
        }

        public void Tidur()
        {
            Console.WriteLine("Tidur");
        }
    }
}
