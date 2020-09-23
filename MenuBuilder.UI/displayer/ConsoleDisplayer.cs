using System;
using System.Collections.Generic;
using MenuBuilder.Core;
using MenuProject;

namespace MenuBuilder.UI
{
    public class ConsoleDisplayer<T> : IMenuDisplayer<T>
    {
        private IWriter Writer { get; }
        public ConsoleDisplayer(IWriter writer)
        {
            Writer = writer;
        }
        public void DisplayNenu(IMenu<T> Menu)
        {

            foreach (KeyValuePair<T, IOption> option in Menu.Options)
            {
                Writer.WriteLine($" *{option.Key},{option.Value.Name}");
            }
        }
    }
}
