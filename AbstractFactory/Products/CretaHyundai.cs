using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products;

public class CretaHyundai : ISuv
{
    public string ExibeDetalhes() => "Hyundai Creta 1.6\nAno 2020";
}