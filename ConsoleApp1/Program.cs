using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Task1();
//Task2();
Task3();




static void Task3()
{

    try
    {

        bool exit = true;
        while (exit)
        {
            decimal kpiBonus = 0;

            Console.WriteLine("\nВведите Зароботную плату");
            string summaryString = Console.ReadLine();
            if (decimal.TryParse(summaryString, out decimal summaryDecimal)) { }
            else
            {
                if (summaryString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }

            Console.WriteLine("\nВведите KPI в процентах");
            string kpiString = Console.ReadLine();
            if (int.TryParse(kpiString, out int kpiInt))
            {
                if (kpiInt >= 90) { kpiBonus = summaryDecimal * 0.2m; }
                else if (kpiInt >= 75 && kpiInt <= 89) { kpiBonus = summaryDecimal * 0.1m; }
                else { kpiBonus = 0; }

            }
            else
            {
                if (kpiString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }

            Console.WriteLine($"Ваша зп равна {summaryDecimal + kpiBonus}");


        }


        




    }
    catch (Exception ex)
    {
        Console.WriteLine($"Возникла ошибка {ex.Message}");
    }


}


















static void Task2()
{
    try
    {

        bool exit = true;
        while (exit)
        {
            Console.WriteLine("\nВведите возраст покупателя");
            string ageString = Console.ReadLine();
            if (int.TryParse(ageString, out int ageInt))
            {
                if (ageInt >= 18) { Console.WriteLine($"Покупатель совершеннолетний"); } else { Console.WriteLine("Покупатель несовершеннолетний"); }


            }
            else
            {
                if (ageString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }


        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Возникла ошибка {ex.Message}");
    }
    












}

static void Task1()
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
