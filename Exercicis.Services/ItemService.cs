using Exercicis.Contracts.Domain.Items;
using Exercicis.Contracts.Domain.Items.Factories;
using Exercicis.Contracts.DTO.Items;
using Exercicis.Core.Commands;
using Exercicis.Core.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicis.Services
{
    public interface IItemService
    {
        IEnumerable<ItemDTO> GetItems();
        ItemDTO GetItem(int id);
        bool AddItem(ItemDTO item);
        bool UpdateItem(ItemDTO item);
        bool DeleteItem(int id);
    }

    public class ItemService : IItemService
    {
        private readonly IItemQuery _iq;
        private readonly IItemCommands _ic;
        public ItemService(IItemQuery itemQuery, IItemCommands itemCommands) 
        {
            _iq = itemQuery;
            _ic = itemCommands;
        }

        public IEnumerable<ItemDTO> GetItems()
        {
            IEnumerable<AItem> items = _iq.GetItems();
            List<ItemDTO> dtos = new List<ItemDTO>();
            foreach(var item in items)
            {
                dtos.Add(ItemDTOFactory.Create(item));
            }
            return dtos;
        }

        public ItemDTO GetItem(int id)
        {
            AItem item = _iq.GetItemById(id);
            return ItemDTOFactory.Create(item);
        }

        public bool AddItem(ItemDTO item)
        {
            AItem nouItem = ItemFactory.Create(item);
            return _ic.AddItem(nouItem);
        }

        public bool UpdateItem(ItemDTO item)
        {
            AItem exist = _iq.GetItemById(item.Id);
            if (exist != null)
            {
                return _ic.UpdateItem(ItemFactory.Create(item));
            }
            else
                return false;
        }

        public bool DeleteItem(int id)
        {
            return _ic.DeleteItem(id);
        }
    }
}
