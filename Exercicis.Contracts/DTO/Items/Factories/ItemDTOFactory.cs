using Exercicis.Contracts.Domain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.DTO.Items
{
    public class ItemDTOFactory
    {
        public static ItemDTO Create(AItem item)
        {
            ItemDTO res = new ItemDTO();
            res.Map(item);
            return res;
        }

        public static ItemDTO Create(ItemDTO item)
        {
            ItemDTO res = new ItemDTO();
            res.Map(item);
            return res;
        }
    }

    public static class ItemDTOExtensions
    {
        public static ItemDTO Map(this ItemDTO res, AItem item)
        {
            res.Id = item.Id;
            res.Codi = item.Codi;
            res.Descripcio = item.Descripcio;
            res.Referencia = item.Referencia;
            res.Preu = item.Preu;

            return res;
        }

        public static ItemDTO Map(this ItemDTO res, ItemDTO item)
        {
            res.Id = item.Id;
            res.Codi = item.Codi;
            res.Descripcio = item.Descripcio;
            res.Referencia = item.Referencia;
            res.Preu = item.Preu;

            return res;
        }
    }
}
