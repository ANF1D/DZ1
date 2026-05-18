decimal discount = default, finalAmount = default;
bool isVip = default, isFirstOrder = default, hasPromo = default, isFreeDelivery = default;

if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
{
    Console.WriteLine("сумма введене не корректно");
}

if (isVip && discount <= 0.2m) { discount += 0.07m; }
if (isFirstOrder && discount <= 0.2m) { discount += 0.05m; }
if (hasPromo && discount <= 0.2m) { discount += 0.1m; }

if (amount >= 15000)
{
    isFreeDelivery = true;
}
else
{
    isFreeDelivery = false;
    finalAmount += 1200m;
}

string deliveryPrice = isFreeDelivery ? "Бесплатно" : "1200";

finalAmount += amount * discount;

Console.WriteLine($"Итоговая скидка: {discount * 100}");
Console.WriteLine($"Стоимость доставки: {deliveryPrice}");
Console.WriteLine($"Финальная сумма к оплате{finalAmount}");