using MenuExampleProject;
using MenuProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuBuilder.UI;

namespace MenuBuilder.Core
{
    public class SubDicitonaryOption<T> : IOption
    {
        public string Name => "New menu";
        private IUserMenu<T> UserMenu { get; }
        private IMenu<T> Menu { get; }

        public SubDicitonaryOption(IUserMenu<T> userMenu, IMenu<T> menu)
        {
            UserMenu = userMenu;
            Menu = menu;
        }

        public IOptionRunResult Run()
        {
            UserMenu.Run(Menu);
            return null;
        }

    }
}
