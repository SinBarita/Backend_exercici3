using Exercicis.Contracts.Domain.LiniesComanda;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicis.Contracts.Domain.Orders
{
    public abstract class AComanda
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public DateTime Data { get; set; }
        public IEnumerable<ALiniaComanda> Linies { get; set; }

        public double Total()
        {
            double total = 0;
            if (Linies != null)
            {
                foreach (ALiniaComanda linia in Linies)
                {
                    total += linia.Preu();
                }
            }
            return total;
        }
    }

    public class Comanda : AComanda { }
}
