using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaytet6.BL
{
    public interface ImengedMissileCollection
    {
        //לעשות הפניות נכונות בין סוגי הפרוייקטים
       ImissileCollection MissileCollection { get; set; }

       void AddMissile();
       void RemoveMissile();



    }
}
