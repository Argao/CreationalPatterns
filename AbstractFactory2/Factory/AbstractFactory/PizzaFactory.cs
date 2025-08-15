using System;
using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;

namespace AbstractFactory2.Factory.AbstractFactory
{
    //ConcreteFactory2
    public sealed class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                {
                    return new PizzaMussarela();
                }
                case TipoPizza.Calabreza:
                {
                   return new PizzaCalabreza();
                }
                default:
                 throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
