using Exercicis.Contracts.Domain.Orders;
using Exercicis.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Services
{
    public interface IOrderService
    {
        IEnumerable<AComanda> GetComandes(string refNumber, DateTime? quan);
        AComanda GetComanda(int id);
    }

    public class OrderService
    {
        private readonly OrderQuery _oq;

        public OrderService() { _oq = new OrderQuery(); }

        public IEnumerable<AComanda> GetComandes(string refNumber, DateTime? quan)
        {
            Func<AComanda, bool> predicateReferencia = (c => true);
            Func<AComanda, bool> predicateData = (c => true);

            var comandes = _oq.getComandes();
            if (!string.IsNullOrWhiteSpace(refNumber))
                predicateReferencia = (c => c.Referencia == refNumber);
            if (quan.HasValue)
                predicateData = (c => c.Data <= DateTime.Today);
            return comandes.Where(predicateReferencia).Where(predicateData);
        }

        public AComanda GetComanda(int id)
        {
            return _oq.getComandaById(id);
        }
    }
}
