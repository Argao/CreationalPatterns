namespace FactoryMethod;

public class SPPizzaFactory : PizzaFactoryMethod
{
    protected override Pizza CriaPizza(string? tipo)
    {
        return tipo switch
        {
            "M" => new SPPizzaMussarela(),
            "C" => new SPPizzaCalabresa(),
            _ => throw new ApplicationException($"A pizza {tipo} não foi criada")
        };
    }
}