namespace Lab1;

// Объявляем класс BallpointPen, который наследует класс Pen и представляет шариковую ручку
public class BallpointPen : Pen
{

    // Объявляем свойство ReplaceableCartridges типа bool для хранения информации о наличии сменных стержней
    public bool ReplaceableCartridges { get; set; }

    // Объявляем конструктор класса BallpointPen, инициализирующий свойства price, manufacturer, lineColor и replaceableCartridges
    public BallpointPen(decimal price, string manufacturer, string lineColor, bool replaceableCartridges)

        // Вызываем конструктор базового класса Pen, передавая значения price, manufacturer и lineColor
        : base(price, manufacturer, lineColor)
    {
        ReplaceableCartridges = replaceableCartridges;
    }
}