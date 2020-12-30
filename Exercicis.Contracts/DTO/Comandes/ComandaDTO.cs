using Exercicis.Contracts.DTO.LiniesComanda;
using System;

namespace Exercicis.Contracts.DTO.Comandes
{
    public class ComandaDTO
    {
        public int Id { get; set; }
        public string Referencia { get; set; }
        public DateTime Data { get; set; }
        public double Amount { get; set; }
        public LiniaComandaDTO[] Linies { get; set; }
    }
}
