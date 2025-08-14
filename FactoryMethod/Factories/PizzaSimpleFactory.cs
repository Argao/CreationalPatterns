namespace FactoryMethod;

public class PizzaSimpleFactory
{
    public static PizzaFactoryMethod CriarPizzaria(string? local)
    {
        return local switch
        {
            "S" => new SPPizzaFactory(),
            "R" => new RJPizzaFactory(),
            _ => throw new ApplicationException($"A pizzaria {local} não foi criada")
        };
    }
}