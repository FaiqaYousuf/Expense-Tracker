using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


           

namespace ASSIGNMENT_3
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Expense Tracker");
                Console.WriteLine("Press Enter To Type The Name Of An Expense");
                Console.ReadKey(); 

                Console.WriteLine("Type The Name Of An Expense");
                string Name = Console.ReadLine(); 

                Console.WriteLine("Press Enter To Type The Cost Of An Expense");
                Console.ReadKey(); 

                Console.WriteLine("Type The Cost Of An Expense");
                string Cost = Console.ReadLine(); 

                Console.WriteLine("The Expense Name Is : " + Name);
                Console.WriteLine("The Cost Of An Expense Is : " + Cost);
                Console.ReadLine(); 
            }
        }
    }


