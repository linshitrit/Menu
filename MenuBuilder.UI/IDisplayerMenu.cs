﻿using MenuBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.UI
{
    public interface IDisplayerMenu<T>
    {
        void DisplayNenu(IMenu<T> menu);

       
    }
}
