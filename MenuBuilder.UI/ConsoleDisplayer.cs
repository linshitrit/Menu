using System;
using System.Collections.Generic;
using MenuBuilder.Core;


namespace MenuBuilder.UI
{
   public class ConsoleDisplayer<T> : IDisplayerMenu<T>
    {
       
        public void DisplayNenu(IMenu<T> Menu)
        {
           
            foreach (KeyValuePair<T, IOption> option in Menu.Options )
            {
                Console.WriteLine($" *{option.Key},{option.Value.Name}");
            }
        }
    }
}
