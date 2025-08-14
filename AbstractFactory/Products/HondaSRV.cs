using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products;

public class HondaSRV : ISuv
{
    public string ExibeDetalhes() => "Honda SR-V Turbo 190c\nAno 2020";
}