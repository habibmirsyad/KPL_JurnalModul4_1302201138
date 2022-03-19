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
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(20);

            data.printAllData();
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

