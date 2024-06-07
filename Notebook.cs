namespace Lab1;

// Объявляем класс Notebook, который реализует интерфейс Stationery и представляет тетрадь
public class Notebook : IStationery
{
    public decimal Price { get; set; }
    public string Manufacturer { get; set; }
    public string Ruling { get; set; }
    public int PageCount { get; set; }

    // Объявляем конструктор класса Notebook, инициализирующий свойства price, manufacturer, ruling и pageCount
    public Notebook(decimal price, string manufacturer, string ruling, int pageCount)
    {
        Price = price;
        Manufacturer = manufacturer;
        Ruling = ruling;
        PageCount = pageCount;
    }
}