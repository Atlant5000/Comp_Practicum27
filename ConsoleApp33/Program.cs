using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Vvod();
            int[] omas = new int[n];
            VvodMass(omas,n);
            Vivodmass(omas);
            Console.ReadLine();
        }
        public static int Vvod()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
        public static void VvodMass(int [] omas,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"omas[{i}]=");
                omas[i]=int.Parse(Console.ReadLine());
            }
        }
        public static void Vivodmass(int [] omas)
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
                Console.WriteLine($"omas[{c}]={omas[c]}");
            }
        }
    }
}
