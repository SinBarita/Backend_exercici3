using Exercicis.Contracts.Domain.Items;
using Exercicis.Contracts.Domain.LiniesComanda;
using Exercicis.Contracts.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Core
{
    public static class MockDatabase
    {
        public static List<AItem> Items = new List<AItem>()
         {
            new Item() { Id = 13, Codi = "ST104-NB", Descripcio = "Agenda Staedler Notebook", Referencia = "AG823491-BF4", Preu = 3.35 },
            new Item() { Id = 19, Codi = "BI9004-77", Descripcio = "Rotulador BIC Model 77", Referencia = "IEF880234", Preu = 1.22 },
            new Item() { Id = 23, Codi = "SM34243-BN", Descripcio = "Tòner Samsung 34243 Negre", Referencia = "VKDS83KSA", Preu = 17.79 },
            new Item() { Id = 27, Codi = "LI675-A1", Descripcio = "Grapadora multifunció Litz", Referencia = "L675-UG", Preu = 4.56 }
        };

        public static List<ALiniaComanda> LiniesA = new List<ALiniaComanda>()
        {
            new LiniaComanda() { IdLinia = 1, Quantitat = 10, Item = Items[0] },
            new LiniaComanda() { IdLinia = 2, Quantitat = 25, Item = Items[2] }
        };

        public static List<ALiniaComanda> LiniesB = new List<ALiniaComanda>()
        {
            new LiniaComanda() { IdLinia = 1, Quantitat = 13, Item = Items[1] },
            new LiniaComanda() { IdLinia = 2, Quantitat = 11, Item = Items[2] },
            new LiniaComanda() { IdLinia = 3, Quantitat = 7, Item = Items[3] }
        };

        public static List<AComanda> Comandes = new List<AComanda>()
        {
            new Comanda() { Id = 9, Data = new DateTime(2020, 11, 11), Referencia = "2020/A2375", Linies = LiniesA },
            new Comanda() { Id = 21, Data = new DateTime(2020, 11, 15), Referencia = "2020/A2381", Linies = LiniesB }
        };
    }
}
