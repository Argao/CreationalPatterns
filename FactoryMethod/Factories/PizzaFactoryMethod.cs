namespace FactoryMethod;

public abstract class PizzaFactoryMethod
{
    public Pizza MontaPizza(string? tipo) => CriaPizza(tipo);

    protected abstract Pizza CriaPizza(string? tipo);
}