using MenuBuilder.Core;
using MenuBuilder.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject
{
    public interface IDataReader<T>
    {
        string Read(IMenu<T> menu);
    }
}
