namespace FactoryMethod;

public class SPPizzaCalabresa : Pizza
{
    public SPPizzaCalabresa()
    {
        Nome = "Pizza de calabresa paulista com muita calabresa";
        massa = "Massa fina crocante paulista";
        molho = "Molho de tomate italiano paulista";
        ingredientes.Add("Fatias de calabresa defumada especial");
        ingredientes.Add("Cebola Roxa");
    }
    
}