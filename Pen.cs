namespace Lab1;

// Объявляем абстрактный класс Pen, который наследует интерфейс Stationery и представляет общие свойства для всех типов ручек
public abstract class Pen : IStationery
{
    public decimal Price { get; set; }
    public string Manufacturer { get; set; }
    public string LineColor { get; set; }

    // Объявляем конструктор класса Pen, инициализирующий свойства Price, Manufacturer и LineColor
    public Pen(decimal price, string manufacturer, string lineColor)
    {

        // Присваиваем значение параметра price свойству Price
        Price = price;

        // Присваиваем значение параметра manufacturer свойству Manufacturer
        Manufacturer = manufacturer;

        // Присваиваем значение параметра lineColor свойству LineColor
        LineColor = lineColor;
    }
}