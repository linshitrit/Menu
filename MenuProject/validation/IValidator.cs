using MenuBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject
{
    public interface IValidator<T>
    {
        bool CheckOption(string input, IMenu<T> menu);
        //bool CheckOption(int input, IntMenu<int> MyMenu);
        //bool CheckOption(string input, StringMenu<string> MyMenu);

    }
}
