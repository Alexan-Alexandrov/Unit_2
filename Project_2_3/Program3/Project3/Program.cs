using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //создание переменных
            short s = 0;
            int i = 0;
            long l = 0;
            float f = 0;
            double d = 15;
            object o = d;

            //переобразование типов переменных
            double d2 = (double)o;
            i = (int)l; l = i;
            ushort a = 15050;
            byte b = (byte)a;

            TestFunc(ref i); // вызов функции

            void TestFunc(ref int value) //передается ссылка на переменную, которую мы изменяем и выводим в консоль
            {
                value = 5;
                Console.WriteLine(i);
            }

            if (o != null) // проверка не пустая-ли переменная типа object, которая ранее была превращена в double
            {
                int hello = Convert.ToInt32(o); // конвертация Double переменной в Int и присваивание значения переменной hello
                Console.WriteLine("  " + hello);
            }

            
            int[] array = new int[10000]; // обычный массив, который не может изменяться по размеру

            List<int> list = new List<int>(80); //динамический массив, который может меняться по размеру

            
        }
    }
}
