using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaytet6.Core
{
   public class MissleCollection : ImissileCollection
    {
       private List<Imissile> MissilesList { get; set; }
       public int CountMissle()
        {
            int count = MissilesList.Count();
            return count;
        }
    }
}
