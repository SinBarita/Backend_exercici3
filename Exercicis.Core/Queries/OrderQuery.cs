using Exercicis.Contracts.Domain.LiniesComanda;
using Exercicis.Contracts.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Core.Queries
{
    public class OrderQuery
    {
        public IEnumerable<AComanda> getComandes()
        {
            return MockDatabase.Comandes;
        }

        public AComanda getComandaById(int id)
        {
            return MockDatabase.Comandes.SingleOrDefault(c => c.Id == id);
        }
    }
}
