using MenuExampleProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
    public class Option3 : IOption
    {
        public string Name
        {
            get => Name = "option3";
            set
            {

            }
        }



        public string Run()
        {
           // Menu<int,IOption> menu = new Menu<int,IOption>();
            string input = "welcom";
            return input;
        }
        // פונקציה שמפנה למופע נוסך של תפריט
        //המיזוג של המנהל תפריט בmain   
    }
}
