namespace Lab1;

// Объявляем класс Marker, который наследует класс Pen и представляет маркер
public class Marker : Pen
{
    public int LineWidth { get; set; }

    // Объявляем конструктор класса Marker, инициализирующий свойства price, manufacturer, lineColor и lineWidth
    public Marker(decimal price, string manufacturer, string lineColor, int lineWidth)

        // Вызываем конструктор базового класса Pen, передавая значения price, manufacturer и lineColor
        : base(price, manufacturer, lineColor)
    {
        LineWidth = lineWidth;
    }
}