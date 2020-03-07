using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieselElcatKgUpper.Classes
{
    public interface IUpper
    {
        void Login(string login, string password);
        void Logout();
        void Up(int themeId);
    }
}
