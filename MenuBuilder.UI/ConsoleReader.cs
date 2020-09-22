using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.UI
{


        public class ConsoleReader : IReader
    {
        public int ReadInt()
        {
            Console.WriteLine("enter a number option in the menu");
            string option = Console.ReadLine();
            int optionInt = int.Parse(option);
            return optionInt;
        }

        public string ReadString()
        {
            Console.WriteLine("enter an string option in the menu");
            string option = Console.ReadLine();
            return option;
        }
    }
}


