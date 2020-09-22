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
            Displayer.DisplayNenu(menu);
            // read option and validate
            DataReader.Read(menu);
            // run option action
            // repeat
        }
    }
}
