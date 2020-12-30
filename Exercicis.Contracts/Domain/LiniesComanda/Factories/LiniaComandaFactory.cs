using Exercicis.Contracts.Domain.Items.Factories;
using Exercicis.Contracts.DTO.LiniesComanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.Domain.LiniesComanda.Factories
{
    public class LiniaComandaFactory
    {
        public static ALiniaComanda Create(ALiniaComanda linia)
        {
            ALiniaComanda res = null;
            Creator creator = null;
            if(linia is LiniaComanda)
            {
                creator = new LiniaComandaCreator();
                res = creator.FactoryMethod();
            }
            res.Map(linia);
            return res;
        }

        public static ALiniaComanda Create(LiniaComandaDTO linia)
        {
            ALiniaComanda res = null;
            Creator creator = null;
            if (linia is LiniaComandaDTO)
            {
                creator = new LiniaComandaCreator();
                res = creator.FactoryMethod();
            }
            res.Map(linia);
            return res;
        }
    }

    public static class LiniaComandaExtensions
    {
        public static ALiniaComanda Map(this ALiniaComanda res, ALiniaComanda linia)
        {
            if(res != null)
            {
                res.IdLinia = linia.IdLinia;
                res.Item = ItemFactory.Create(linia.Item);
                res.Quantitat = linia.Quantitat;
            }
            return res;
        }

        public static ALiniaComanda Map(this ALiniaComanda res, LiniaComandaDTO linia)
        {
            if (res != null)
            {
                res.IdLinia = linia.IdLinia;
                res.Item = ItemFactory.Create(linia.Item);
                res.Quantitat = linia.Quantitat;
            }
            return res;
        }
    }
}
