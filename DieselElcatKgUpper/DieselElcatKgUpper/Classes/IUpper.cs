namespace DieselElcatKgUpper.Classes
{
    public interface IUpper
    {
        void Login(string login, string password);
        void Logout();
        void Up(string themeurl);
    }
}
