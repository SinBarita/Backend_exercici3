using Exercicis.Contracts.DTO.Items;

namespace Exercicis.Contracts.Domain.Items.Factories
{
    public class ItemFactory
    {
        public static AItem Create(AItem item)
        {
            AItem res = null;
            Creator creator = null;
            if(item is Item)
            {
                creator = new ItemCreator();
                res = creator.FactoryMethod();
            }
            res.Map(item);

            return res;
        }

        public static AItem Create(ItemDTO item)
        {
            AItem res = null;
            Creator creator = null;
            if(item is ItemDTO)
            {
                creator = new ItemCreator();
                res = creator.FactoryMethod();
            }
            res.Map(item);

            return res;
        }
    }

    public static class ItemExtensions
    {
        public static AItem Map(this AItem res, AItem item)
        {
            if (res != null)
            {
                res.Id = item.Id;
                res.Codi = item.Codi;
                res.Descripcio = item.Descripcio;
                res.Referencia = item.Referencia;
                res.Preu = item.Preu;
            }
            return res;
        }

        public static AItem Map(this AItem res, ItemDTO item)
        {
            if(res != null)
            {
                res.Id = item.Id;
                res.Codi = item.Codi;
                res.Descripcio = item.Descripcio;
                res.Referencia = item.Referencia;
                res.Preu = item.Preu;
            }
            return res;
        }
    }
}
