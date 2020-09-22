using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuBuilder.UI
{
   public interface IReader
    {
        int ReadInt();

        string ReadString();
    }
}
