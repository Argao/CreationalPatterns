namespace FactoryMethod;

public class SPPizzaMussarela : Pizza
{
    public SPPizzaMussarela()
    {
        Nome = "Pizza de mussarela paulista";
        massa = "Massa fina crocante paulista";
        molho = "Molho de tomate italiano paulista";
        ingredientes.Add("Queijo Mussarela");
        ingredientes.Add("Azeitonas verdes");
    }
}