namespace Lab1;

// Объявляем класс Pencil, который реализует интерфейс Stationery и представляет простой карандаш
public class Pencil : IStationery
{
    public decimal Price { get; set; }
    public string Manufacturer { get; set; }
    public string Hardness { get; set; }
    public string LineColor { get; set; }
    public int Length { get; set; }

    // Объявляем конструктор класса Pencil, инициализирующий свойства price, manufacturer, hardness, lineColor и length
    public Pencil(decimal price, string manufacturer, string hardness, string lineColor, int length)
    {

        Price = price;
        Manufacturer = manufacturer;
        Hardness = hardness;
        LineColor = lineColor;
        Length = length;
    }
}