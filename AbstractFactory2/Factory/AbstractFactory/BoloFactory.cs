using System;
using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;

namespace AbstractFactory2.Factory.AbstractFactory
{
    //ConcreteFactory1
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    {
                        return new BoloChocolate();
                    }
                case TipoBolo.Laranja:
                    {
                        return new BoloLaranja();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }

    }
}
