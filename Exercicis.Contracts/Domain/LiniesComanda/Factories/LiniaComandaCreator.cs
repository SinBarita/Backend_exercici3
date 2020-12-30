using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.Domain.LiniesComanda.Factories
{    
    public abstract class Creator
    {
        public abstract ALiniaComanda FactoryMethod();
    }

    public class LiniaComandaCreator : Creator
    {
        public override ALiniaComanda FactoryMethod()
        {
            return new LiniaComanda();
        }
    }
}
