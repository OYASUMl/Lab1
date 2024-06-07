namespace Lab1;

// Объявляем класс WritingSupplies
public class WritingSupplies
{
    // Объявляем приватное поле supplies типа List<Stationery> для хранения списка письменных принадлежностей
    private List<IStationery> supplies = new List<IStationery>();

    // Объявляем метод AddSupply
    public void AddSupply(IStationery supply)
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