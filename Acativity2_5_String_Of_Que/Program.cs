using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acativity2_5_String_Of_Que
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strung = new Queue<string>();
            strung.Enqueue("Bagabag");
            strung.Enqueue("Villaverde");
            strung.Enqueue("Solano");
            strung.Enqueue("Aritao");
            strung.Enqueue("Bayombong");
            strung.Enqueue("Bambang");
            strung.Enqueue("Ambaguio");
            strung.Enqueue("Santafe");
            List<string> towns = new List<string>(strung);
            foreach (var items in strung)
            { 
                towns.Add(items);
            }
            string searchTown = "";
            Console.WriteLine("List of Towns:"+"\nenter(strop) to stop searching");
            do {
                Console.WriteLine("Enter town to search: ");
                searchTown = Console.ReadLine();
                if (towns.Contains(searchTown))
                {
                    Console.WriteLine($"Town found: [{searchTown}]");
                }
                else
                {
                    Console.WriteLine("Town not found");
                }

            }while (searchTown != "stop");


            printItems(strung);

                       
            Console.ReadKey();
        }
        //print items in list
        //add a statement to search a town in out queue
        //if town is dearch found, print "Town found" else not found
        //add a stateemnt to reapeat the process until user wants to stop
        private static void printItems(Queue<string> strung)
        {
            foreach (var item in strung)
            {
                //Console.WriteLine($"[{item}]");
            }
        }
    }
}
