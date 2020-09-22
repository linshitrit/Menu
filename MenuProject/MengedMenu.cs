using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder.Core;
using MenuProject;


namespace MenuProject
{
    public class MengedMenu<T> : IMengedMenu<T>
    {
        public void AddOption(T input, IOption option,IMenu<T> menu)
        { 
            menu.Options.Add(input, option);
         
        }

        public void RemoveOption(T input, IMenu<T> menu)
        {
            menu.Options.Remove(input);
        }

    }
}
