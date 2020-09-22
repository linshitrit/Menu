using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder.Core;
using MenuProject;

namespace MenuProject
{
    public interface IMengedMenu<T>
    {

        void AddOption(T input, IOption option, IMenu<T> menu);

        void RemoveOption(T input, IMenu<T> menu);


    }
}
