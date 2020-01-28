using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = "Ticket.cvs";
            string option;
            do
            { 
                Console.WriteLine("1 | Read ticket information:");
                Console.WriteLine("2 | Add new ticket information:");
                Console.WriteLine("Press any key to exit");
                option = Console.ReadLine();

                if (option == "1")
                {
                    if(File.Exists(ticket))
                    {

                    }
                }
            }
      
        }
    }
}
