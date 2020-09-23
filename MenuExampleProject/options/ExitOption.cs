
using MenuProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuBuilder.Core
{
    public class ExitOption : IOption
    {
        public string Name => "exit";
        private IWriter Writer => new ConsoleWriter();
        public IOptionRunResult Run()
        {
            Writer.WriteLine("bye bye");
            return new OptionRunResult
            {
                ExitMenu = true
            };
        }
    }
}
