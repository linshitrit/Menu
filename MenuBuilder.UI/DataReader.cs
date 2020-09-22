using MenuBuilder.Core;
using MenuBuilder.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProject
{
   public class DataReader<T> : IDataReader<T>
    {
        public IValidator<T> Validator { get; set; }
        public IReader Reader { get; set; }
       

        public DataReader(IValidator<T> validator, IReader reader)
        {
            Validator = validator;
            Reader = reader;
        }
       public string Read(IMenu<T> menu)
        {
           while (true)
            {
                if (typeof(T) == (typeof(int)))
                {
                    string input1 = Reader.ReadString();
                    bool validInt = Validator.CheckOption(input1, menu);
                    if (!validInt)
                    {
                        return "the input is not valid";
                    }
                }
            }
           
        }

    }
}
