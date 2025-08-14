using AbstractFactory.Products.Interfaces;

namespace AbstractFactory;

public class Cliente(ISuv suv, ISedan sedan)
{
    public string GetSuvDetalhes() => suv.ExibeDetalhes();
    public string GetSedanDetalhes() => sedan.ExibeDetalhes();
}