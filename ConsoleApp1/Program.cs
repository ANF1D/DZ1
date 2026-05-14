using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

NewMethod();

static void NewMethod()
{
    string resultMessage = "Ваш ответ равен ";
    try
    {
        bool exit = true;
        while (exit)
        {

            Console.WriteLine("\nВведите первое число");
            string firstValueString = Console.ReadLine();
            if (int.TryParse(firstValueString, out int firstValueInt)) { }
            else
            {
                if (firstValueString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }



            Console.WriteLine("Введите операцию");
            string operation = Console.ReadLine();
            if (operation.Trim().ToLower() == "exit") { exit = false; break; }




            Console.WriteLine("Введите второе число");
            string secondValueString = Console.ReadLine();
            if (int.TryParse(secondValueString, out int secondValueInt)) { }
            else
            {
                if (secondValueString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }

            
            switch (operation)
            {
                case "+":
                    Console.WriteLine(resultMessage += (firstValueInt + secondValueInt));
                    break;
                case "-":
                    Console.WriteLine(resultMessage += (firstValueInt - secondValueInt));
                    break;
                case "*":
                    Console.WriteLine(resultMessage += (firstValueInt * secondValueInt));
                    break;
                case "/":
                    Console.WriteLine(resultMessage += (firstValueInt / secondValueInt));
                    break;
                case "%":
                    Console.WriteLine(resultMessage += (firstValueInt % secondValueInt));
                    break;
                default:
                    Console.WriteLine($"Операция {operation} не поддерживается");
                    break;
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Возникла ошибка {ex.Message}");
    }

}
