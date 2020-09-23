using MenuProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder.Core
{
    public class UpperCaseOption : IOption
    {
        public string Name => "to upper case";
        private IWriter Writer { get; }
        public UpperCaseOption(IWriter writer)
        {
            Writer = writer;
        }
        public IOptionRunResult Run()
        {
            Writer.WriteLine("enter a string: ");
            string input = Console.ReadLine().ToUpper();
            Writer.WriteLine(input);

            return null;
        }
    }

}