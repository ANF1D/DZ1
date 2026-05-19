using System.Diagnostics;
using System.Linq.Expressions;

//decimal discount = default, finalAmount = default;
//bool isVip = true, isFirstOrder = true, hasPromo = true, isFreeDelivery = default;

//Console.WriteLine("Введите сумму заказа");
//if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
//{
//    Console.WriteLine("сумма введене не корректно");     
//}

//finalAmount += amount;

//Console.WriteLine("Введите ");

//if (isFirstOrder)       discount += 0.05m; 
//if (hasPromo)           discount += 0.1m; 
//if (isVip)              discount += 0.07m; 
//if (discount >= 0.2m)   discount = 0.2m;
//if (amount >= 15000m)
//{
//    isFreeDelivery = true;
//}
//else
//{
//    isFreeDelivery = false;
//    finalAmount += 1200m;
//}

//string deliveryPrice = isFreeDelivery ? "Бесплатно" : "1200";
//finalAmount -= amount * discount;

//Console.WriteLine($"Итоговая скидка: {discount * 100}%");
//Console.WriteLine($"Стоимость доставки: {deliveryPrice}");
//Console.WriteLine($"Финальная сумма к оплате: {finalAmount}");

decimal summary = default, net = default, tax = 0.1m;
double dayRate = 5, nightRate = 10, overtime;

Console.WriteLine("Введите количество часов в дневной смене");
if (!double.TryParse(Console.ReadLine(), out double dayHours))
{
    Console.WriteLine("Значение введено не корректно");
}
Console.WriteLine("Введите количество часов в ночной смене");
if (!double.TryParse(Console.ReadLine(), out double nightHours))
{
    Console.WriteLine("Значение введено не корректно");
}

Console.WriteLine("Введите weekendShift");
if (!bool.TryParse(Console.ReadLine(), out bool weekendShift))
{
    Console.WriteLine("Значение введено не корректно, надо true или false");
}
double allHours = dayHours + nightHours;
summary = (decimal)(dayHours * dayRate + nightHours * nightRate);

if (allHours > 160) overtime = allHours - 160 * dayRate * 1.5;
if (weekendShift) summary += summary * 0.5m;

net = summary - (summary * tax);

Console.WriteLine($"Gross = {summary}");
Console.WriteLine($"Net = {net}");
