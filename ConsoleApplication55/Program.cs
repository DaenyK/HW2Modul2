using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            int nz;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("which task?(0 - exit)");
                nz = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (nz)
                {
                    case 0:
                        {
                        }
                        break;
                    case 1:
                        {
                            task1();
                        }
                        break; ;

                    case 2:
                        {
                            task2();
                        }
                        break;
                    case 3:
                        {
                            task3();
                        }
                        break;

                    case 4:
                        {
                            task4();
                        }
                        break;

                    case 5:
                        {
                            task5();
                        }
                        break;

                    case 6:
                        {
                            task6();
                        }
                        break;

                    case 7:
                        {
                            task7();
                        }
                        break;

                    case 8:
                        {
                            task8();
                        }
                        break;

                    case 9:
                        {
                            task9();
                        }
                        break;

                    case 10:
                        {
                             task10();
                        }
                        break;
                }
                Console.WriteLine();
            } while (nz > 0);
        }

        static void task1()
        {
            Console.Write("введите любое предложение, программа остановится и посчитает кол-во пробелов, после того, как вы введете точку: ");
            string str = "";
            int i = 0;
            do
            {
                str += Console.ReadLine();
                i++;
            } while (!str.Contains('.'));

            int countSpace = str.Count(w => w == ' ');

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if (str[k] == ' ')
                    b++;
            }

            Console.WriteLine("кол-во пробелов: " + countSpace);

        }

        static void task2()
        {
            Console.Write("введите 6-значное число: ");
            string ticket = Console.ReadLine();
            if (ticket.Length == 6)
            {
                int sum1 = ticket[0] + ticket[1] + ticket[2];
                int sum2 = ticket[3] + ticket[4] + ticket[5];

                if (sum1 == sum2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("билет счастливый");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("билет не счастливый");
                }
                Console.ForegroundColor = ConsoleColor.White;

            }
        }

        static void task3()
        {
            //4.Даны целые положительные числа A и B (A < B).Вывести все целые числа от A до B включительно;
            //каждое число должно выводиться на новой строке; при этом каждое число должно выводиться 
            //количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна 
            //сформировать в консоли следующий вывод: 
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7
            Console.Write("введите цифру A: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("введите цифру B: ");
            int b = Int32.Parse(Console.ReadLine());
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    for (int j = 0; j < i; j++)
                        Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("а равно b, либо больше b");
        }

        static void task4()
        {
            //5.Дано целое число N(> 0), найти число, полученное при прочтении числа N 
            //справа налево. Например, если было введено число 345, то программа должна 
            //вывести число 543.
            Console.Write("введите любую цифру: ");
            string a = Console.ReadLine();
            if (Int32.Parse(a) > 0)
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write(a[i]);
                }
            else Console.WriteLine("ваше число меньше или равно нулю");
        }

        static void task5()
        {
            //6.	Составить программу вывода на экран в одну строку 
            // трех любых чисел с двумя пробелами между ними.  
            string str;
            Random rnd = new Random();
            str = rnd.Next(1, 30) + "  " + rnd.Next(31, 60) + "  " + rnd.Next(61, 90);
            Console.WriteLine(str);
        }

        static void task6()
        {
            Console.WriteLine("Вывести на экран числа 5, 10 и 21 одно под другим.");
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }

        static void task7()
        {
            Console.Write("введите кол-во см: ");
            double sm = Int32.Parse(Console.ReadLine());
            Console.WriteLine("полных метров: " + sm / 100 + " м");
        }

        static void task8()
        {
            Console.WriteLine("С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период?");
            Console.WriteLine("ОТВЕТ: {0} полных недель прошло", 234 / 7);
        }

        static void task9()
        {
            Console.WriteLine("Дано двузначное число. Найти:");
            Console.WriteLine("a.число десятков в нем; ");
            Console.WriteLine("b.число единиц в нем; ");
            Console.WriteLine("c.сумму его цифр; ");
            Console.WriteLine("d.произведение его цифр");
            Console.Write("введите любое двузначное число: ");
            int x = Int32.Parse(Console.ReadLine());
            if (x > 9 && x < 100)
            {
                Console.WriteLine("a.число десятков в нем: {0}", x / 10);
                Console.WriteLine("b.число единиц в нем: {0}", x - (x / 10) * 10);
                Console.WriteLine("c.сумму его цифр: {0}", x / 10 + (x - (x / 10) * 10));
                Console.WriteLine("d.произведение его цифр: {0}", (x / 10) * (x - (x / 10) * 10));
            }
            else
            {
                Console.WriteLine("вы ввели не двузначное число");
            }
        }

        static void task10()
        {
            //34. .Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
           Console.Write("введите цифру от 1 до 7: ");
            int a = Int32.Parse(Console.ReadLine());
            DayOfWeek dow = (DayOfWeek)a;
            Console.WriteLine(dow);
        }
    }
}
