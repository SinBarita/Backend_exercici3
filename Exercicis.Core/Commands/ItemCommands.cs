using Exercicis.Contracts.Domain.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Core.Commands
{
    public interface IItemCommands
    {
        bool AddItem(AItem item);
        bool UpdateItem(AItem item);
        bool DeleteItem(int id);
    }

    public class ItemCommands : IItemCommands
    {
        public ItemCommands() { }

        public bool AddItem(AItem item)
        {
            MockDatabase.Items.Add(item);
            return true;
        }

        public bool UpdateItem(AItem item)
        {
            AItem old = MockDatabase.Items.Find(i => i.Id == item.Id);
            if (old != null)
            {
                old.Codi = item.Codi;
                old.Descripcio = item.Descripcio;
                old.Preu = item.Preu;
                old.Referencia = item.Referencia;
                return true;
            }
            else
                return false;
        }

        public bool DeleteItem(int id)
        {
            AItem toDelete = MockDatabase.Items.Find(i => i.Id == id);
            if (toDelete != null)
            {
                MockDatabase.Items.Remove(toDelete);
                return true;
            }
            else
                return false;
        }
    }
}
