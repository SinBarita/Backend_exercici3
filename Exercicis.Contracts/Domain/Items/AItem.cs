using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.Domain.Items
{
    public abstract class AItem
    {
        public int Id { get; set; }
        public string Codi { get; set; }
        public string Descripcio { get; set; }
        public string Referencia { get; set; }
        public double Preu { get; set; }
    }

    public class Item : AItem { }
}
