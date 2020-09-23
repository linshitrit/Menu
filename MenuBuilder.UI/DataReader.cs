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
        public int Read(IMenu<T> menu)
        {
            string input = Reader.ReadString();
            if (Validator.CheckOption(input, menu))
            {
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
            }

            return -1;
        }

    }
}
