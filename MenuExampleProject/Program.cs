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
            IWriter writer = new ConsoleWriter();
            IOption firstOption = new ConcatOption(writer);
            IOption secondOption = new UpperCaseOption(writer);


            IDictionary<int, IOption> Subdictionary = new Dictionary<int, IOption>();
            IMenu<int> subMenu = new Menu<int>(Subdictionary);
            IMenuDisplayer<int> displaySubMenu = new ConsoleDisplayer<int>(writer);
            IValidator<int> validator = new MenuValidator<int>();
            IReader reader = new ConsoleReader(writer);
            IDataReader<int> dataReader = new DataReader<int>(validator, reader);

            IUserMenu<int> userSubMenu = new UserMenu<int>(displaySubMenu, dataReader, writer);


            IOption thirdOption = new SubDicitonaryOption<int>(userSubMenu, subMenu);
            IOption lastOption = new ExitOption();
            IMengedMenu<int> subMengedMenu = new MengedMenu<int>(subMenu);
            subMengedMenu.AddOption(1, firstOption);
            subMengedMenu.AddOption(4, lastOption);
            IDictionary<int, IOption> dictionary = new Dictionary<int, IOption>();
            IMenu<int> menu = new Menu<int>(dictionary);
            IMengedMenu<int> mengedMenu = new MengedMenu<int>(menu);
            mengedMenu.AddOption(1, firstOption);
            mengedMenu.AddOption(2, secondOption);
            mengedMenu.AddOption(3, thirdOption);
            mengedMenu.AddOption(4, lastOption);
            IMenuDisplayer<int> displayMenu = new ConsoleDisplayer<int>(writer);
            //IValidator<int> validator = new MenuValidator<int>();
            //IReader reader = new ConsoleReader(writer);
            //IDataReader<int> dataReader = new DataReader<int>(validator, reader);

            IUserMenu<int> mainMenu = new UserMenu<int>(displayMenu, dataReader, writer);
            mainMenu.Run(menu);
        }
    }

}
