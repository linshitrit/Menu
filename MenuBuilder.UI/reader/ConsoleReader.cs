using MenuProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.UI
{


    public class ConsoleReader : IReader
    {
        private IWriter Writer { get; }
        public ConsoleReader(IWriter writer)
        {
            Writer = writer;
        }
        public int ReadInt(string? message)
        {
            if (message != null)
            {
                Writer.WriteLine(message);
            }

            string option = Console.ReadLine();
            int optionInt = int.Parse(option);
            return optionInt;
        }
            
        public string ReadString()
        {
            Writer.WriteLine("enter an string option in the menu");
            string option = Console.ReadLine();
            return option;
        }
    }
}


