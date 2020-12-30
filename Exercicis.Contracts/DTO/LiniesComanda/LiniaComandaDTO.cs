using Exercicis.Contracts.DTO.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.DTO.LiniesComanda
{
    public class LiniaComandaDTO
    {
        public int IdLinia { get; set; }
        public ItemDTO Item { get; set; }
        public int Quantitat { get; set; }
        public double Preu { get; set; }
    }
}
