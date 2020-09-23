using MenuProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
    public interface IOption
    {
        string Name { get; }
        IOptionRunResult Run();
    }

}
