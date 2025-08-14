using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products;

public class HB20Hyundai : ISedan
{
    public string ExibeDetalhes() => "Hyundai HB20  1.6\nAno 2020";   
}