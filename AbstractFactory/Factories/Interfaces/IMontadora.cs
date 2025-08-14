using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Interfaces;

public interface IMontadora
{
    ISuv CriarSuv();
    ISedan CriarSedan();   
}