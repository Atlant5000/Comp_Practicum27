using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    /// <summary>
    /// Задача 1. Заполнить одномерный массив с клавиатуры и вывести его на экран в обратном порядке (с использованием for, Reverse()).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=Vvod();
           int[] omas = new int[n];
           VvodMassiv(omas,n);
           VivodMassiv(omas,n);
           Array.Reverse(omas);
           VivodMassiv(omas, n);
           Console.ReadLine();
        }
        public static int Vvod()
        { 
            Console.Write("n=");
            int n=int.Parse(Console.ReadLine());
            return n;
        }
        public static void VvodMassiv(int[] omas,int n)
        {
            for (int i = 0; i < n; i++) 
            {
                Console.Write($"omas[{i}]=");
                omas[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void VivodMassiv(int[] omas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
    }
}
