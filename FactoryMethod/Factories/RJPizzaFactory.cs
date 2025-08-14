namespace FactoryMethod;

public class RJPizzaFactory : PizzaFactoryMethod
{
    protected override Pizza CriaPizza(string? tipo)
    {
        return tipo switch
        {
            "M" => new RJPizzaMussarela(),
            "C" => new RJPizzaCalabresa(),
            _ => throw new ApplicationException($"A pizza {tipo} não foi criada")
        };
    }
}