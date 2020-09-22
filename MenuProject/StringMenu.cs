using MenuBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject
{
    public class StringMenu<T> : IMenu <string>
    {
        public IDictionary<string, IOption> Options { get; set; }

    }
}


