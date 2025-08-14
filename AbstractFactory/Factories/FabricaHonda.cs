using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories;

public class FabricaHonda : IMontadora
{
    public ISuv CriarSuv() => new HondaSRV();

    public ISedan CriarSedan() => new HondaCivic();  
}