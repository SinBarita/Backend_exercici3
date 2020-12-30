using Exercicis.Contracts.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Core.Commands
{
    public class ComandesCommands
    {
        public ComandesCommands() { }

        public void AddComanda(AComanda ordre)
        {
            MockDatabase.Comandes.Add(ordre);
        }

        public void UpdateComanda(AComanda ordre)
        {
            AComanda old = MockDatabase.Comandes.Find(c => c.Id == ordre.Id);
            old.Data = ordre.Data;
            old.Referencia = ordre.Referencia;
            old.Linies = ordre.Linies;
        }

        public void DeleteComanda(int id)
        {
            AComanda toDelete = MockDatabase.Comandes.Find(c => c.Id == id);
            MockDatabase.Comandes.Remove(toDelete);
        }
    }
}
