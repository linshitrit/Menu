using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder.Core;
using MenuBuilder.UI;
using MenuProject;
using MenuProject.BL;

namespace MenuExampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Option1 firstOption = new Option1();
            Option2 secondOption = new Option2();
            Option4 lastOption = new Option4();
            IMenu<int> menu = new Menu<int>();
            MengedMenu<int> mengedMenu = new MengedMenu<int>();
            mengedMenu.AddOption(1, firstOption, menu);
            mengedMenu.AddOption(1, secondOption, menu);
            mengedMenu.AddOption(1, lastOption, menu);
            IDisplayerMenu<int> displayMenu = new ConsoleDisplayer<int>();
            IValidator<int> validator = new MenuValidator<int>();
            IReader reader = new ConsoleReader();
            IDataReader<int> dataReader = new DataReader<int>(validator,reader);
            UserMenu<int> mainMenu = new UserMenu<int>(displayMenu, dataReader);
            mainMenu.Run(menu);


 
        }
    }
}
