using System;
using System.Collections.Generic;
using System.Text;
/*создание класса Account*/
namespace Account
{
    class Account
    {
        public string login;
        public string name;
        public string password;

        public void GetInfo();
        {
        Console.WriteLine ($ "Логин: {login} Имя: {name} Пароль: {password}");
    }
}
class Program
{
    static void Main(string[] args)

    /*создадим один объект класса Account*/
    {
        Account Person = new Account();

        Person.GetInfo();

        Person.login = Kris10an;
        Person.name = KristianBerg;
        Person.password = 1234;

        Person.GetInfo(); 
        Console.ReadKey();
    }
}



