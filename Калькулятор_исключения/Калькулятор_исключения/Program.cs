using NLog;
using System;

namespace Калькулятор_исключения

/*написать калькулятор*/
{
    class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            log.Debug("сообщение о дебаге");
            log.Error("сообщение об ошибке");

            while (true)
            {
                Console.Clear();
                double FirstValue, SecondValue;
                string Action;
                /*обработка ситуации если вместо цифр ввели буквенное значение*/
                try
                {
                    Console.WriteLine("Введите первое число");
                    FirstValue = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    SecondValue = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    log.Error("ввод нечислового значения");
                    Console.WriteLine("Error! Введите число!");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine("Выберите действие '+' '-' '*' '/'");
                Action = Console.ReadLine();

                switch (Action)

                {
                    default:
                        Console.WriteLine("Error!");
                        break;

                    case "+":
                        Console.WriteLine(FirstValue + SecondValue);
                        break;

                    case "-":
                        Console.WriteLine(FirstValue - SecondValue);
                        break;

                    case "*":
                        Console.WriteLine(FirstValue * SecondValue);
                        break;

                    case "/":
                        if (SecondValue == 0)
                        {
                            log.Error("на ноль делить нельзя");
                            Console.WriteLine("Нельзя делить на ноль");
                        }
                        {
                           Console.WriteLine(FirstValue / SecondValue);
                        }
                        break; 
                }
          

                        
                Console.ReadLine();

                }
            }
        }
    }


   
