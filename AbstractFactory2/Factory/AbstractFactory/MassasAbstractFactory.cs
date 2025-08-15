using System;
using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;

namespace AbstractFactory2.Factory.AbstractFactory
{
    //AbstractFactory
    public abstract class MassasAbstractFactory
    {
        public abstract MassaBase CriaMassa(TipoMassa tipoMassa);
        public static MassasAbstractFactory CriaFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                {
                    return new PizzaFactory();
                }
                case TipoMassa.Bolo:
                {
                    return new BoloFactory();
                }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa), tipoMassa, null);
            }
        }
    }
}
