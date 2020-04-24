using System;

namespace SEND
    {

        class account_базаданныхсайта


        {

            public string login;
            public string name;
            public object password;

            public account_базаданныхсайта()
            {
                login = "Skogen";
                name = "TrineHjerbb";
                password = "e567";


                Print();
            }


            public account_базаданныхсайта(string _login, string _name, object _password)
            {
                login = _login;
                name = _name;
                password = _password;


                Print();

            }

            public void Print()
            {
                Console.WriteLine("login:" + login);
                Console.WriteLine("name:" + name);
                Console.WriteLine("password:" + password);


            }
        }

        class MainClass
        {
            public static void Main(string[] args)
            {
                account_базаданныхсайта account1 = new account_базаданныхсайта();
                Console.WriteLine();
                account_базаданныхсайта account2 = new account_базаданныхсайта("kristian", "KristianBerg", "t1234");


                Console.WriteLine();
                Console.ReadKey();

            }
        }
    }
