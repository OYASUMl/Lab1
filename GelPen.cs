namespace Lab1;

// Объявляем класс GelPen, который наследует класс Pen и представляет гелиевую ручку
public class GelPen : Pen
{

    // Объявляем свойство GelMass типа double для хранения массы геля в ручке
    public double GelMass { get; set; }

    // Объявляем конструктор класса GelPen, инициализирующий свойства price, manufacturer, lineColor и gelMass
    public GelPen(decimal price, string manufacturer, string lineColor, double gelMass)

        // Вызываем конструктор базового класса Pen, передавая значения price, manufacturer и lineColor
        : base(price, manufacturer, lineColor)
    {
        GelMass = gelMass;
    }
}