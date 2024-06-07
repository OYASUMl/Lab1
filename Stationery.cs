namespace Lab1;

// Объявляем интерфейс Stationery, который описывает базовые свойства всех письменных принадлежностей
public interface IStationery
{
    // Объявляем свойство Price типа decimal для хранения цены
    decimal Price { get; set; }

    // Объявляем свойство Manufacturer типа string для хранения производителя
    string Manufacturer { get; set; }
}

