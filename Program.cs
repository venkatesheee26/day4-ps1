
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter marks in Pre: ");
            int preMarks = Convert.ToInt32(Console.ReadLine());

            if (preMarks > 60)
            {
                Console.Write("Enter marks in Final: ");
                int finalMarks = Convert.ToInt32(Console.ReadLine());

                if (finalMarks > 55)
                {
                    Console.WriteLine("Selected");
                }
                else
                {
                    Console.WriteLine("Fail in Final");
                }
            }
            else
            {
                Console.WriteLine("Fail in Pre");
            }

            Console.ReadLine();

        }
    }
}
