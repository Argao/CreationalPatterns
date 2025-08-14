namespace FactoryMethod;

public class RJPizzaMussarela : Pizza
{
    public RJPizzaMussarela()
    {
        Nome = "Pizza de mussarela carioca";
        massa = "Massa fina crocante carioca";
        molho = "Molho de tomate italiano";
        ingredientes.Add("Queijo Mussarela");
        ingredientes.Add("Azeitonas pretas");
        ingredientes.Add("Oregano");
    }
}
