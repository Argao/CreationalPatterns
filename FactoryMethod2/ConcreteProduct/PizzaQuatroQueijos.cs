using FactoryMethod2.Product;

namespace FactoryMethod2.ConcreteProduct
{
    //ConcreteProduct
    public class PizzaQuatroQueijos : Pizza
    {
        public PizzaQuatroQueijos()
        {
            Nome = "Pizza Quatro Queijos";
            Ingredientes.Add("Queijo Parmessão");
            Ingredientes.Add("Queijo Gorgonzola");
            Ingredientes.Add("Queijo Brie");
            Ingredientes.Add("Queijo Provolone");
        }
        public override string Nome { get; }
    }
}
