namespace FactoryMethod;

public class RJPizzaCalabresa : Pizza
{
    public RJPizzaCalabresa()
    {
        Nome = "Pizza de calabresa carioca";
        massa = "Massa Artezanal";
        molho = "Molho de tomate italiano";
        ingredientes.Add("Fatias de calabresa defumada especial");
        ingredientes.Add("Cebola Roxa");
        ingredientes.Add("Queijo Mussarela");
    }
}