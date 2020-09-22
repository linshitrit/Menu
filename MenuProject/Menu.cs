using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
    public class IntMenu<T> : IMenu<T>
    {
        public IDictionary<T, IOption> Options { get; set; }
       
    }
}

