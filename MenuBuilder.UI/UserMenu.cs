using MenuBuilder.UI;
using MenuBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MenuProject
{
    public class UserMenu<T>
    {
        private IDisplayerMenu<T> Displayer { get; }
        private IDataReader<T> DataReader { get;  }

        public UserMenu(IDisplayerMenu<T> displayer, IDataReader<T> dataReader)
        {
            Displayer = displayer;
            DataReader = dataReader;

        }
        public void Run(IMenu<T> menu)
        {
            // display options
            Console.WriteLine("welcome to our menu:");
            while (true)
            {
                Displayer.DisplayNenu(menu);
                // read option and validate
                int read = DataReader.Read(menu);
                if (read != -1 && read !=4)
                {
                    // run option action
                    var readT = menu.Options
                                    .First(item => item.Key.Equals(read)).Key;
                    Console.WriteLine(menu.Options[readT].Run());  
                }
                if(read == 4)
                {
                    Console.WriteLine("bye bye");
                    break;
                }
            }
          
        }
    }
}
