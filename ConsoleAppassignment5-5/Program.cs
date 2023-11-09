using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppassignment5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Score : ");
            int Score=int.Parse(Console.ReadLine());

            if (Score >=90)
            {
                Console.WriteLine("grade : A");
            }
            else if (Score <90 && Score >=80)
            {
                Console.WriteLine("grade :B");
            }
            else if (Score <80 && Score >=70)
            {
                Console.WriteLine("grade : C");
            }
            else if (Score <70 && Score >=60)
            {
                Console.WriteLine("grade : D");
            }
            else
            {
                Console.WriteLine("grade : F");
            }
            Console.ReadKey();
        }
    }
}
