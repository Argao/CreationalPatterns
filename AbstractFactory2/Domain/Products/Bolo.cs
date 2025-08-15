using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products
{
    //AbstractProductA
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}
