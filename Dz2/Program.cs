using System.Diagnostics;
using System.Linq.Expressions;

OnlineStore();
Console.WriteLine("\n___________________________________________________________ \n");
HR();

static void OnlineStore()
{
    try
    {
        decimal discount = default, finalAmount = default;
        bool isFreeDelivery = default;

        Console.WriteLine("Введите сумму заказа");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            throw new Exception("сумма введена не корректно");
        }
        Console.WriteLine("Vip (true/false)");
        if (!bool.TryParse(Console.ReadLine(), out bool isVip))
        {
            throw new Exception("Значение введено не корректно");
        }
        Console.WriteLine("Первый заказ (true/false)");
        if (!bool.TryParse(Console.ReadLine(), out bool isFirstOrder))
        {
            throw new Exception("Значение введено не корректно");
        }
        Console.WriteLine("Есть ли промокод (true/false)");
        if (!bool.TryParse(Console.ReadLine(), out bool hasPromo))
        {
            throw new Exception("Значение введено не корректно");
        }




        finalAmount += amount;

        if (isFirstOrder) discount += 0.05m;
        if (hasPromo) discount += 0.1m;
        if (isVip) discount += 0.07m;
        if (discount >= 0.2m) discount = 0.2m;
        if (amount >= 15000m)
        {
            isFreeDelivery = true;
        }
        else
        {
            isFreeDelivery = false;
            finalAmount += 1200m;
        }

        string deliveryPrice = isFreeDelivery ? "Бесплатно" : "1200";
        finalAmount -= amount * discount;

        Console.WriteLine($"Итоговая скидка: {discount * 100}%");
        Console.WriteLine($"Стоимость доставки: {deliveryPrice}");
        Console.WriteLine($"Финальная сумма к оплате: {finalAmount}");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    
    
}

static void HR()
{
    try
    {
        decimal summary = default, net = default, tax = 0.1m;
        double dayRate = 5, nightRate = 10, overtime;

        Console.WriteLine("Введите количество часов в дневной смене");
        if (!double.TryParse(Console.ReadLine(), out double dayHours))
        {
            throw new Exception("Значение введено не корректно");
        }
        Console.WriteLine("Введите количество часов в ночной смене");
        if (!double.TryParse(Console.ReadLine(), out double nightHours))
        {
            throw new Exception("Значение введено не корректно");
        }

        Console.WriteLine("Введите weekendShift (true/false)");
        if (!bool.TryParse(Console.ReadLine(), out bool weekendShift))
        {
            throw new Exception("Значение введено не корректно");
        }
        double allHours = dayHours + nightHours;
        summary = (decimal)(dayHours * dayRate + nightHours * nightRate);

        if (allHours > 160) overtime = allHours - 160 * dayRate * 1.5;
        if (weekendShift) summary += summary * 0.5m;

        net = summary - (summary * tax);

        Console.WriteLine($"Gross = {summary}");
        Console.WriteLine($"Net = {net}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    

}