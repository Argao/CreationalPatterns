using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories;

public class FabricaHyundai : IMontadora
{
    public ISuv CriarSuv() => new CretaHyundai();

    public ISedan CriarSedan() => new HB20Hyundai(); 

}