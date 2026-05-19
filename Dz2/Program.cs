using System.Diagnostics;
using System.Linq.Expressions;

decimal discount = default, finalAmount = default;
bool isVip = true, isFirstOrder = true, hasPromo = true, isFreeDelivery = default;

Console.WriteLine("Введите сумму заказа");
if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    Console.WriteLine("сумма введене не корректно");     
}

finalAmount += amount;

Console.WriteLine("Введите ");

if (isFirstOrder)       discount += 0.05m; 
if (hasPromo)           discount += 0.1m; 
if (isVip)              discount += 0.07m; 
if (discount >= 0.2m)   discount = 0.2m;
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