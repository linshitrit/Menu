using MenuBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MenuProject.BL
{
    public class MenuValidator<T> : IValidator<T>
    {

        //public bool CheckOption(int input, IntMenu<int> MyMenu)
        //{
          
        //    return MyMenu.Options.ContainsKey(input);
        //}

        //public bool CheckOption(string input, StringMenu <string> MyMenu)
        //{
        //    return MyMenu.Options.ContainsKey(input);
        //}

        public bool CheckOption(string input, IMenu<T> menu)
        {
            return menu.Options.Any(option => option.ToString() == input);
        }
    }
}
