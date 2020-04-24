using System;
using System.Collections.Generic;
using System.Text;

namespace Account
/*создать абстрактный класс account_базаданныхсайта и от него класс account а от него VIP_account*/
{
    abstract class account_базаданныхсайта

    {
        public string login { get; set; }
        public string name { get; set; }
        protected object password { get; set; }

    }
    class account : account_базаданныхсайта
    {
        public void main(string Rain, string Ksusha, object e123)
        {

            this.login = Rain;
            this.name = Ksusha;
            this.password = e123;
            Console.WriteLine(login, name, password);
        }
        class VIP_account : account
        {
            public void Main(string Lucky1, string Aleksey, object t12t12)
            {
                this.login = Lucky1;
                this.name = Aleksey;
                this.password = t12t12;


                {
                    Console.WriteLine(login);
                    Console.WriteLine(name);





                    Console.ReadKey();

                }
            }

        }
    }
}   

