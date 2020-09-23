
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuBuilder.Core
{
     public class Option4 : IOption
    {
        public string Name
        {
            get => Name = "option4";
            set
            {

            }
        }

        public string Run()
        {

            string input = "bye bye";
            Environment.Exit(-1);
            return input;



        }

    }
}
