using Exercicis.Contracts.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.Domain.Comandes.Factories
{
    public abstract class Creator
    {
        public abstract AComanda FactoryMethod();
    }
    public class ComandaCreator : Creator
    {
        public override AComanda FactoryMethod()
        {
            return new Comanda();
        }
    }
}
