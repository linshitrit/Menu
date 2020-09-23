using MenuBuilder.Core;

namespace MenuProject
{
    public interface IUserMenu<T>
    {
        void Run(IMenu<T> menu);
    }
}
