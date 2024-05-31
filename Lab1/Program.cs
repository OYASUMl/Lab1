namespace Lab1;

// Объявляем интерфейс Stationery, который описывает базовые свойства всех письменных принадлежностей
public interface Stationery
{
    // Объявляем свойство Price типа decimal для хранения цены
    decimal Price { get; set; }

    // Объявляем свойство Manufacturer типа string для хранения производителя
    string Manufacturer { get; set; } 
}

// Объявляем абстрактный класс Pen, который наследует интерфейс Stationery и представляет общие свойства для всех типов ручек
public abstract class Pen : Stationery
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

// Объявляем класс Pencil, который реализует интерфейс Stationery и представляет простой карандаш
public class Pencil : Stationery 
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

// Объявляем класс Notebook, который реализует интерфейс Stationery и представляет тетрадь
public class Notebook : Stationery 
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

// Объявляем класс WritingSupplies
public class WritingSupplies 
{
    // Объявляем приватное поле supplies типа List<Stationery> для хранения списка письменных принадлежностей
    private List<Stationery> supplies = new List<Stationery>();

    // Объявляем метод AddSupply
    public void AddSupply(Stationery supply) 
    {
        // Добавляем переданную письменную принадлежность в список supplies
        supplies.Add(supply); 
    }

    // Объявляем метод GetTotalSuppliesCount
    public int GetTotalSuppliesCount() 
    {
        // Возвращаем количество элементов в списке supplies
        return supplies.Count; 
    }
    // Объявляем метод GetTotalPrice
    public decimal GetTotalPrice() 
    {
        // Возвращаем сумму цен всех элементов в списке supplies, используя тип Sum()
        return supplies.Sum(s => s.Price); 
    }
}

// Объявляем класс Program
public class Program 
{
    // Объявляем точку входа в программу с помощью статистического метода Main
    public static void Main(string[] args) 
    {
        // Создаем новый экземпляр класса WritingSupplies
        WritingSupplies supplies = new WritingSupplies(); 

        // Добавляем письменные принадлежности
        supplies.AddSupply(new GelPen(10, "Фирма 1", "Белый", 10)); 
        supplies.AddSupply(new BallpointPen(20, "Фирма 2", "Синий", true));
        supplies.AddSupply(new Pencil(30, "Фирма 3", "HB", "Черный", 20)); 
        supplies.AddSupply(new Marker(40, "Фирма 4", "Желтый", 30)); 
        supplies.AddSupply(new Notebook(50, "Фирма 5", "Красный", 40)); 

        // Вывод количества и общей стоимости
        Console.WriteLine($"Общее количество письменных принадлежностей: {supplies.GetTotalSuppliesCount()}");
        Console.WriteLine($"Общая стоимость: {supplies.GetTotalPrice()}"); 
    }
}

