namespace SimpleFactory;

public class PizzaSimpleFactory
{
    public static Pizza CriarPizza(string? tipo)
    {
        Pizza pizza = tipo switch
        {
            "C" => new PizzaCalabresa(),
            "M" => new PizzaMussarela(),
            _ => throw new ApplicationException($"A Pizza {tipo} não foi criada")
        };

        return pizza;
    }
}