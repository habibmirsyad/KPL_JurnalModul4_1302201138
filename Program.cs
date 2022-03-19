using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_1302201138_MOD4_JURNAL_GGR
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            // nim = "1302201138";
            Penjumlahan<int> penjumlahan = new Penjumlahan<int>();
            penjumlahan.JumlahTigaAngka(13,02,20);
          
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(20);

            data.printAllData();
        }
    }
}

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

    class SimpleDataBase<T>
    { 
        public SimpleDataBase<T>
        {
            List<T> storedData;
            List<DateTime> inputDates;    

            public void addNewData(T data)
            {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }

            public void printAllData()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Data "+ i+ "berisi: "+ storedData[i]+ "yang disimpan pada waktu "+ inputDates[i]);
                }
            }
        }
    }

