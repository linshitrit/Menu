using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
    public class Option2 : IOption
    {
        public string Name
        {
            get => Name = "option2";
            set
            {

            }
        }

        public string Run()
        {
            Console.WriteLine("enter a string: ");
            string input = Console.ReadLine();
            input = input.ToUpper(); 
            return input;
        }
    }
}