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
        private IMenu<T> Menu { get; set; }
        public MengedMenu(IMenu<T> menu)
        {
            Menu = menu;
        }

        public void AddOption(T input, IOption option)
        {
            Menu.Options.Add(input, option);
        }

        public void RemoveOption(T input)
        {
            Menu.Options.Remove(input);
        }
    }
}
