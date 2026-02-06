using System;

abstract class Delivery
{
    public string Address;
    public abstract void ShowDeliveryInfo();
}

// Доставка на дом
class HomeDelivery : Delivery
{
    public string CourierName { get; set; }
    public decimal DeliveryPrice { get; set; }
    public DateTime EstimatedTime { get; set; }

    public override void ShowDeliveryInfo()
    {
        Console.WriteLine($"Доставка на дом по адресу: {Address}");
        Console.WriteLine($"Курьер: {CourierName}, стоимость: {DeliveryPrice} руб, время: {EstimatedTime}");
    }
}

// Пункт выдачи
class PickPointDelivery : Delivery
{
    public string Company { get; set; }
    public string PickupPoint { get; set; }
    public DateTime AvailableFrom { get; set; }

    public override void ShowDeliveryInfo()
    {
        Console.WriteLine($"Пункт выдачи: {PickupPoint} ({Company})");
        Console.WriteLine($"Адрес: {Address}");
        Console.WriteLine($"Можно забрать с: {AvailableFrom}");
    }
}

// Самовывоз из магазина
class ShopDelivery : Delivery
{
    public string ShopName { get; set; }

    public override void ShowDeliveryInfo()
    {
        Console.WriteLine("Доставка в розничный магазин");
        Console.WriteLine($"Магазин: {ShopName}");
        Console.WriteLine($"Адрес магазина: {Address}");
        Console.WriteLine("Доставка осуществляется внутренними средствами компании");
    }
}



class Product
{
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
}


// Заказ, который содержит информацию о доставке и список товаров
class Order
{
    public Delivery Delivery;
    public Product[] Products { get; set; }

    public bool HasProduct(string productName)
    {
        foreach (var product in Products)
        {
            if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                return true;
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        // Выводим список товаров
        Order order = new Order
        {
            Products = new Product[]
            {
                new Product { ProductName = "Телефон Apple 13pro", ProductPrice = 130000 },
                new Product { ProductName = "Ноутбук Asus", ProductPrice = 70000 },
                new Product { ProductName = "Наушники Sony", ProductPrice = 15000 },
                new Product { ProductName = "Часы smart watch2", ProductPrice = 5000 },
                new Product { ProductName = "Колонка", ProductPrice = 10000 }
            }
        };

        
        Console.WriteLine("Товары:");
        foreach (var product in order.Products)
        {
            Console.WriteLine($"{product.ProductName} - {product.ProductPrice} руб");
        }

        // Водим название товара
        Console.WriteLine("\nЧто вы хотите заказать?");
        string productName = Console.ReadLine();

        if (!order.HasProduct(productName))
        {
            Console.WriteLine("Такого товара нет.");
            return;
        }

        // Водим тип доставки
        Console.WriteLine("Выберите тип доставки: \n1 - На дом \n2 - Пункт выдачи \n3 - Самовывоз");
        string choice = Console.ReadLine();

        // Инициализация доставки в зависимости от выбора пользователя
        switch (choice)
        {
            case "1":
                Console.WriteLine("Введите адрес:");
                order.Delivery = new HomeDelivery
                {
                    Address = Console.ReadLine(),
                    CourierName = "Дмитрий Баранов",
                    DeliveryPrice = 200,
                    EstimatedTime = DateTime(2)
                };
                break;

            case "2":
                order.Delivery = new PickPointDelivery
                {
                    Address = "ул. Пушкина, 5",
                    Company = "PickPoint",
                    PickupPoint = "Пункт №7",
                    AvailableFrom = DateTime.Now.AddHours(1)
                };
                break;

            case "3":
                order.Delivery = new ShopDelivery
                {
                    ShopName = "Фирменный магазин",
                    Address = "пр. Ленина, 10"
                };
                break;

            default:
                Console.WriteLine("Неверный выбор");
                return;
        }

        // Вывод информации о доставке
        Console.WriteLine("\nИнформация о доставке:");
        order.Delivery.ShowDeliveryInfo();
    }
}
