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
    public class UserMenu<T> : IUserMenu<T>
    {
        private IMenuDisplayer<T> Displayer { get; }
        private IDataReader<T> DataReader { get; }
        private IWriter Writer { get; }


        public UserMenu(IMenuDisplayer<T> displayer, IDataReader<T> dataReader, IWriter writer)
        {
            Displayer = displayer;
            DataReader = dataReader;
            Writer = writer;

        }
        public void Run(IMenu<T> menu)
        {
            // display options
            Writer.WriteLine("welcome to our menu:");
            while (true)
            {
                Displayer.DisplayNenu(menu);
                // read option and validate
                int input = DataReader.Read(menu);
                if (input != -1)
                {
                    // run option action
                    var option = menu.Options.First(item => item.Key.Equals(input)).Value;
                    bool? exitMenu = option.Run()?.ExitMenu;

                    if (exitMenu != null && exitMenu == true)
                    {
                        break;
                    }


                    Writer.WriteLine("---------------------------------");
                }
                else
                {
                    Writer.WriteLine("the input is not valid");
                }
            }

        }
    }
}
