using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    /// <summary>
    /// Задача 3. В одномерном массиве, заполненном с использованием явной инициализации, найти:
    /// 1. максимальный элемент и его индекс;
    /// 2. минимальный элемент и его индекс;
    /// 3. поменять местами максимальный и минимальный элементы, вывести одномерный массив;
    /// 4. количество элементов между максимальным и минимальным элементами.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] omas = {-5,12,-15,26,-12,-32,7,18,-40};
            Findmaxnumberofmass(omas);
            Findminnumberofmass(omas);
            Changeminandmaxmass(omas);
            Findquantitybetweenminandmax(omas);
            Console.ReadKey();
        }
        public static void Findmaxnumberofmass(int[] omas)
        {
            int MaxMass = omas[0];
            int IndexMaxMass=0;
            for (int i=0; i < omas.Length; i++)
            {
                if (MaxMass < omas[i])
                {
                    MaxMass = omas[i];
                    IndexMaxMass = i;
                }
            }
            Console.WriteLine($"Максимальный элемент массива - omas[{IndexMaxMass}]={omas[IndexMaxMass]}");
        }
        public static void Findminnumberofmass(int[] omas)
        {
            int MinMass = omas[0];
            int IndexMinMass = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if (MinMass > omas[i])
                {
                    MinMass = omas[i];
                    IndexMinMass = i;
                }
            }
            Console.WriteLine($"Минимальный элемент массива - omas[{IndexMinMass}]={omas[IndexMinMass]}");
        }
        public static void Changeminandmaxmass(int[] omas)
        {
            int MaxMass = omas[0];
            int IndexMaxMass = 0;
            int MinMass = omas[0];
            int IndexMinMass = 0;
            int a = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if (MaxMass < omas[i])
                {
                    MaxMass = omas[i];
                    IndexMaxMass = i;
                }
            }
            for (int i = 0; i < omas.Length; i++)
            {
                if (MinMass > omas[i])
                {
                    MinMass = omas[i];
                    IndexMinMass = i;
                }
            }
            a = omas[IndexMaxMass];
            omas[IndexMaxMass] = omas[IndexMinMass];
            omas[IndexMinMass] = a;
            for (int i = 0; i < omas.Length; i++) 
            {
                Console.WriteLine($"omas[{i}]={omas[i]}");
            }
        }
        public static void Findquantitybetweenminandmax(int[] omas)
        {
            int MaxMass = omas[0];
            int IndexMaxMass = 0;
            int MinMass = omas[0];
            int IndexMinMass = 0;
            for (int i = 0; i < omas.Length; i++)
            {
                if (MaxMass < omas[i])
                {
                    MaxMass = omas[i];
                    IndexMaxMass = i;
                }
            }
            for (int i = 0; i < omas.Length; i++)
            {
                if (MinMass > omas[i])
                {
                    MinMass = omas[i];
                    IndexMinMass = i;
                }
            }
            int b = IndexMinMass - IndexMaxMass - 1;
            if (b < 0)
            {
                b = IndexMaxMass - IndexMinMass - 1;
            }
            Console.WriteLine($"Количесво элементов между максимальным и минимальным элементами = {b}");
        }
    }
}