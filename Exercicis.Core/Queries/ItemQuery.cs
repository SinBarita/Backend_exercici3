using System.Collections.Generic;
using System.Linq;
using Exercicis.Contracts.Domain.Items;

namespace Exercicis.Core.Queries
{
    public interface IItemQuery
    {
        IEnumerable<AItem> GetItems();
        AItem GetItemById(int id);
    }

    public class ItemQuery : IItemQuery
    {
        public ItemQuery() { }

        public IEnumerable<AItem> GetItems()
        {
            return MockDatabase.Items;
        }

        public AItem GetItemById(int id)
        {
            return MockDatabase.Items.SingleOrDefault(i => i.Id == id);
        }        
    }
}
