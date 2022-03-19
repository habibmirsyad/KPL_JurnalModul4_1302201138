using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_1302201138_MOD4_JURNAL_GGR
{
    public class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T satu, T dua, T tiga)
        {
            int Satu = Convert.ToInt32(satu);
            int Dua = Convert.ToInt32(dua);
            int Tiga = Convert.ToInt32(tiga);
            Console.WriteLine(Satu+Dua+Tiga);
        }
    }

internal class Program
    {
        static void Main(string[] args)
        {
            // nim = "1302201138";
            Penjumlahan<int> penjumlahan = new Penjumlahan<int>();


            penjumlahan.JumlahTigaAngka(13,02,20);
        }
    }
}
