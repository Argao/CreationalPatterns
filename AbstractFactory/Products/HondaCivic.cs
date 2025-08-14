using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products;

public class HondaCivic : ISedan
{
    public string ExibeDetalhes() => "Honda Civic 1.5 173 cv\nAno 2020";  
}