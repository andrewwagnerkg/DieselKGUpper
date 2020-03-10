using System;

namespace DieselElcatKgUpper.Classes
{
    public interface IUpper : IDisposable
    {
        void Login(string login, string password);
        void Logout();
        void Up(string themeurl);
    }
}
