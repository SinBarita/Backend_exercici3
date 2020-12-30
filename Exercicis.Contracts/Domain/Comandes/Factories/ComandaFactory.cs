using Exercicis.Contracts.Domain.LiniesComanda;
using Exercicis.Contracts.Domain.LiniesComanda.Factories;
using Exercicis.Contracts.Domain.Orders;
using Exercicis.Contracts.DTO.Comandes;
using Exercicis.Contracts.DTO.LiniesComanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Contracts.Domain.Comandes.Factories
{
    public class ComandaFactory
    {
        public static AComanda Create(AComanda ordre)
        {
            AComanda res = null;
            Creator creator = null;
            if(ordre is Comanda)
            {
                creator = new ComandaCreator();
                res = creator.FactoryMethod();
            }
            res.Map(ordre);
            return res;
        }

        public static AComanda Create(ComandaDTO ordre)
        {
            AComanda res = null;
            Creator creator = null;
            if (ordre is ComandaDTO)
            {
                creator = new ComandaCreator();
                res = creator.FactoryMethod();
            }
            res.Map(ordre);
            return res;
        }
    }

    public static class ComandaExtensions
    {
        public static AComanda Map(this AComanda res, AComanda ordre)
        {
            if(res != null && ordre != null)
            {
                res.Id = ordre.Id;
                res.Data = ordre.Data;
                res.Referencia = ordre.Referencia;
                var lista = new List<ALiniaComanda>();
                foreach(ALiniaComanda linia in ordre.Linies)
                {
                    lista.Add(LiniaComandaFactory.Create(linia));
                }
                res.Linies = lista;
            }
            return res;
        }

        public static AComanda Map(this AComanda res, ComandaDTO ordre)
        {
            if (res != null && ordre != null)
            {
                res.Id = ordre.Id;
                res.Data = ordre.Data;
                res.Referencia = ordre.Referencia;
                var lista = new List<ALiniaComanda>();
                foreach (LiniaComandaDTO linia in ordre.Linies)
                {
                    lista.Add(LiniaComandaFactory.Create(linia));
                }
                res.Linies = lista;
            }
            return res;
        }
    }
}
