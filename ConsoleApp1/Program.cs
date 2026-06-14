Calculator();
AgeVerifiction();
Kpi();

static void Kpi()
{
    try
    {
        bool exit = default;
        string kpiString;
        while (!exit)
        {
            decimal kpiBonus = 0;

            Console.WriteLine("\nВведите Заработную плату");
            string summaryString = Console.ReadLine() ?? string.Empty;
            if (decimal.TryParse(summaryString, out decimal summaryDecimal)) ;
            else
            {
                if (summaryString.Trim().ToLower() == "exit")
                {
                    exit = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }

            Console.WriteLine("\nВведите KPI в процентах");
            kpiString = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(kpiString, out int kpiInt))
            {
                if (kpiInt >= 90) kpiBonus = summaryDecimal * 0.2m;
                else if (kpiInt >= 75 && kpiInt <= 89) { kpiBonus = summaryDecimal * 0.1m; }
                else { kpiBonus = 0; }

            }
            else
            {
                if (kpiString.Trim().ToLower() == "exit") 
                { 
                    exit = true; 
                    break;
                }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }

            Console.WriteLine($"Ваша зп равна {summaryDecimal + kpiBonus}");


        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Возникла ошибка {ex.Message}");
    }
}

static void AgeVerifiction()
{
    try
    {

        bool exit = true;
        string ageString;
        while (exit)
        {
            Console.WriteLine("\nВведите возраст покупателя");
            ageString = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(ageString, out int ageInt))
            {
                if (ageInt <= 0) {Console.WriteLine($"Не корректный возраст"); continue; }
                if (ageInt > 100) {Console.WriteLine($"Не корректный возраст"); continue; }
                if (ageInt >= 18) 
                { 
                    Console.WriteLine($"Покупатель совершеннолетний");
                }  
                else Console.WriteLine("Покупатель несовершеннолетний");


            }
            else
            {
                if (ageString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }


        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Возникла ошибка {ex.Message}");
    }

}

static void Calculator()
{
    string secondValueString = string.Empty, firstValueString = string.Empty, operation = string.Empty;
    try
    {
        bool exit = default;
        while (!exit)
        {

            Console.WriteLine("\nВведите первое число");
            firstValueString = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(firstValueString, out double firstValueDouble)) { }
            else
            {
                if (firstValueString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }



            Console.WriteLine("Введите операцию");
            operation = Console.ReadLine() ?? string.Empty;
            if (operation.Trim().ToLower() == "exit") { exit = false; break; }




            Console.WriteLine("Введите второе число");
            secondValueString = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(secondValueString, out double secondValueDouble)) { }
            else
            {
                if (secondValueString.Trim().ToLower() == "exit") { exit = false; break; }
                else
                {
                    Console.WriteLine("Введена не цифра, для корректной работы использйте цифры \n");
                    continue;
                }

            }


            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Результат сложения = {(firstValueDouble + secondValueDouble)}" );
                    break;
                case "-":
                    Console.WriteLine($"Результат вычетание = {(firstValueDouble - secondValueDouble)}");
                    break;
                case "*":
                    Console.WriteLine($"Результат умножение = {(firstValueDouble * secondValueDouble)}");
                    break;
                case "/":
                    Console.WriteLine($"Результат деление = {(firstValueDouble / secondValueDouble)}");
                    break;
                case "%":
                    Console.WriteLine($"Результат определение остатка = {(firstValueDouble % secondValueDouble)}");
                    break;
                default:
                    Console.WriteLine($"Операция {operation} не поддерживается");
                    break;
            }

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Возникла ошибка {ex.Message}");
    }

}