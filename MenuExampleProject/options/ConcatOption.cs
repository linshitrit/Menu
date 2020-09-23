using MenuProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuBuilder.Core
{
    public class ConcatOption : IOption
    {
        public string Name => "concat string";
        private IWriter Writer { get; }
        public ConcatOption(IWriter writer)
        {
            Writer = writer;
        }
        public IOptionRunResult Run()
        {

            Writer.WriteLine("enter a string: ");
            string input = Console.ReadLine();
            input = string.Concat(Enumerable.Repeat(input, 3));
            Writer.WriteLine(input);

            return null;
        }
    }
}
