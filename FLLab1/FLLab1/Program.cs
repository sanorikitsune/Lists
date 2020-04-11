using System;
using System.Collections.Generic;

namespace FLLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> List1 = new List<int>() { 1, 2, 3, 45 };
            List<int> List2 = new List<int>() { 8, 9, 11, 32 };

            while (true){

                Console.Write("|");
                for (int i = 0; i < List1.Count; i++)
                {
                    Console.Write(List1[i]);
                    Console.Write("|");
                }
                Console.Write("\n|");
                for (int i = 0; i < List2.Count; i++)
                {
                    Console.Write(List2[i]);
                    Console.Write("|");
                }

                string answer;

                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Удалить элемент по номеру. Задание 4.");
                Console.WriteLine("2. Вставка в список другого списка. Задание 16.");
                Console.WriteLine("3. Заменить все четные по номеру элементы на произвольную константу. Задание 22.");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        List1 = Delete(List1);
                        break;
                    case "2":
                        List1 = InsertList(List1, List2);
                        break;
                    case "3":
                        List1 = Replace(List1);
                        break;
                    default:
                        Console.WriteLine("Неверное значение\n");
                        break;


                }
            }




        }



        static List<int> Delete (List<int> List)
        {
            Console.WriteLine("\nВведите номер элемента, который вы хотите удалить:");
            string Input = Console.ReadLine();
            int N;
            Int32.TryParse(Input, out N);

            while (!(Int32.TryParse(Input, out N)) || !(N < List.Count))
            {
                Console.WriteLine($"Введите целое число от 0 до {List.Count - 1}. Попробуйте еще раз");
                Input = Console.ReadLine();
            }

            List.RemoveAt(N);
            Console.WriteLine("\n");
            return List;
        }

        static List<int> InsertList (List<int> List1, List<int> List2 )
        {
            Console.WriteLine("\nВведите номер элемента, c которого вы хотите вставить:");
            string Input = Console.ReadLine();
            int N;
            Int32.TryParse(Input, out N);

            while (!(Int32.TryParse(Input, out N)) || !(N < List1.Count))
            {
                Console.WriteLine($"Введите целое число от 0 до {List1.Count - 1}. Попробуйте еще раз");
                Input = Console.ReadLine();
            }

            List1.InsertRange(N, List2);
            Console.WriteLine("\n");
            return List1;
        }




        static List<int> Replace(List<int> List1)
        {
            Random rnd = new Random();
            for (int i=0; i<List1.Count; i=i+2)
            {
                List1[i] = rnd.Next(100);
                Console.WriteLine(List1[i]);
            }
            return List1;
        }
    }
}
