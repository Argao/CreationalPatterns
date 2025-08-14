using FactoryMethod2.ConcreteProduct;
using FactoryMethod2.Creator;
using FactoryMethod2.Product;

namespace FactoryMethod2.ConcreteCreator
{
    //Concrete Creator
    public class PizzaFactory : PizzaFactoryMethod
    {
        public override Pizza CriarPizza(int tipo)
        {
            var factory = PizzaFactories[tipo];
            return factory();
        }

        public static Dictionary<int, Func<Pizza>> PizzaFactories =
                  new Dictionary<int, Func<Pizza>>
        {
                  { 1, ()=>new PizzaCalabreza() },
                  { 2, ()=>new PizzaMussarela() },
                  { 3, ()=>new PizzaPortuguesa()},
                  { 4, ()=>new PizzaQuatroQueijos() },
        };
    }
}

