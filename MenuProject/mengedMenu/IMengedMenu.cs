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
        IMenu<T> Menu { get; set; }

        void AddOption(T input, IOption option);

        void RemoveOption(T input);


    }
}
