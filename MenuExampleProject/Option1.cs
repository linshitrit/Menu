using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
    public class Option1: IOption
    {
        public string Name
        {
            get => Name = "option1";
            set
            {

            }
        }

        public string Run()
        {
            Console.WriteLine("enter a string: ");
            string input = Console.ReadLine();
            input = string.Concat(Enumerable.Repeat(input, 3));
            return input;
        }


    }
}
