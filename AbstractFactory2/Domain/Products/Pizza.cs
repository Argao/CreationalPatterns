using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products
{
    //AbstractProductB
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
