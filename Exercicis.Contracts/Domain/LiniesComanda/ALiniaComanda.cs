using Exercicis.Contracts.Domain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.Domain.LiniesComanda
{
    public abstract class ALiniaComanda
    {
        public int IdLinia { get; set; }
        public AItem Item { get; set; }
        public int Quantitat { get; set; }

        public double Preu() { return Item.Preu * Quantitat; }
    }

    public class LiniaComanda : ALiniaComanda { }
}
