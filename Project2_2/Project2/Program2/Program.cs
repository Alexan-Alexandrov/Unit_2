using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    /* - Программа выводит информацию класса в консоль
    internal class Program
    {

        class House
        {
            private string street;
            private int number;

            public House (string street, int number)
            {
                this.street = street;
                this.number = number;
            }
            public void Print()
            {
                Console.WriteLine($"{street}, {number}");
            }
        }

        static void Main()
        {
            House referenceHouse = new House("Проспект мира", 5);
            referenceHouse.Print();

        }
    }
    */

    /* - Базовые функции (вывести Helo World, Сложить сумму, Вывесьт имя и возраст человека)
    internal class Program
    {
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

        static void Human(string name, int age)
        {
            Console.WriteLine($"{name}, {age}");
        }

        static void Main(string[] args)
        {
            HelloWorld();
            Sum(1, 2);
            Human("sasha", 22);
        }
    }
    */

    /* - Сравнивает числа и выводит это в консоль
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = 10;

            if (b > a)
            {
                Console.WriteLine($"Число {b} больше числа {a}");
            }
            else if (b < a)
            {
                Console.WriteLine($"Число {b} меньше числа {a}");
            }
            else
            {
                Console.WriteLine($"Число {b} равно числу {a}");
            }
        }
    }
    */

    /* - выводит в консоль по порядку цифры от 1 до 9 через цикл For
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    */

    /* - выводит в консоль цифры от 1 до 9 через цикл While
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (index < 9)
            {
                index++;
                Console.WriteLine(index);
            }
        }
    }
    */

    /* - работа с массивами, ищет одинаковые элементы в массиве
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 3, 4, 5, 6, 7 };

            foreach (int num1 in numbers1)
            {
                foreach (int num2 in numbers2)
                {
                    if (num1 == num2)
                    {
                        Console.Write(" " + num1 + " ");
                    }
                }
            }
        }
    }
    */
    
}
        



  
