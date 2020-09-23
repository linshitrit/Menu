using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
  
    public interface IMenu<T>
    {
        IDictionary<T, IOption> Options { get; set; }

      
    }
}
