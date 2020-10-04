using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaytet6.Core
{
    public interface Imissile
    {
        string Name { get; set; }
        int Probability { get; set; }
        bool WasLauncher { get; set; }

        void Launch();


    }
}
