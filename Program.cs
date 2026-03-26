using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace LearnGit
{
    internal class Program
    {

        static int BinarySearch(int[] list, int number)
        {
            int first = 0;
            int last = list.Length - 1;

            while (last >= first)
            {
                int midPoint = (first + last) / 2;

                if (list[midPoint] == number)
                {
                    return midPoint;
                }
                else if (list[midPoint] < number)
                {
                    first = midPoint + 1;
                }
                else
                {
                    last = midPoint - 1;
                }
            }

            return -1; // Element not found
        }

        static int NormalSearch(int[] list, int number)
        {
            for(int i=0;i<list.Length;i++)
            {
                if (list[i] == number)
                {
                    return i;
                }
            }
            return -1;
           
        }
        static void Print(int Number)
        {
            if (Number !=0)
                Console.WriteLine($"I Found the Number in position  {Number}");
            else
            {
                Console.WriteLine("Number didnt exist !!");
            }
        }
        

        static int[] FillArray (int From,int To)
        {
            int[] FilledArrar=new int[To-From+1];
            for(int i=0;i<=To-From;i++)
            {
                FilledArrar[i] = From + i;
            }
            return FilledArrar;
        }
        
        static void Main(string[] args)
        {
            int[] List = FillArray(0, 1000000);
            
            Stopwatch s=new Stopwatch();
            s.Start();
            Print( BinarySearch(List, 99900));
            s.Stop();

            Console.WriteLine($"Finished at {s.ElapsedMilliseconds}");
            Stopwatch s2=new Stopwatch();
            s2.Start();
            Print(NormalSearch(List, 99900));

            s2.Stop();
            Console.WriteLine($"Finished at {s.ElapsedMilliseconds}");
            Console.ReadLine();

        }
    }
}
