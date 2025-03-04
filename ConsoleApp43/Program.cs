using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    /// <summary>
    /// Задача 2. Заполнить одномерный массив случайным образом и выполнить сортировку
    /// по возрастанию (через вложенный цикл, с использованием метода Sort()).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = Vvod();
                int[] omas = new int[n];
                VvodMass(omas, n);
                Array.Sort(omas);
                VivodMass(omas);
                Console.ReadLine();
            }
        }
        public static int Vvod()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void VvodMass(int[] omas, int n)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                omas[i] = random.Next(-100, 100);
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void VivodMass(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        /*public static void Sortmass(int[] omas)
        {
            for (int c = 0; c < omas.Length; c++)
            {

                int a;
                for (int i = 0; i < omas.Length - 1; i++)
                {
                    for (int j = 0; j < omas.Length; j++)
                    {
                        if (omas[i] > omas[j])
                        {
                            a = omas[i];
                            omas[i] = omas[j];
                            omas[j] = a;
                        }
                    }
                }
            }
        }*/
    }
}
