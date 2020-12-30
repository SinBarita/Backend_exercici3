using Exercicis.Contracts.DTO.Items;
using Exercicis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Exercicis.Controllers
{
    /// <summary>
    /// Controlador d'ítems
    /// </summary>
    public class ItemController : ApiController
    {
        private readonly IItemService _is;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="itemService"></param>
        public ItemController(IItemService itemService) { _is = itemService; }

        /// <summary>
        /// Obtindre tots els ítems
        /// </summary>
        /// <returns></returns>
        [Route("Items")]
        [HttpGet]
        public IHttpActionResult getItems()
        {
            return Ok(_is.GetItems());
        }

        /// <summary>
        /// Obtindre un ítem
        /// </summary>
        /// <param name="id">Número d'ítem</param>
        /// <returns></returns>
        [Route("Items/id")]
        [HttpGet]
        public IHttpActionResult getItems(int id)
        {
            if (id > 0)
                return Ok(_is.GetItem(id));
            else
                return BadRequest("Out of range item");
        }

        /// <summary>
        /// Afegir un ítem
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [Route("Items")]
        [HttpPost]
        public IHttpActionResult addItem(ItemDTO item)
        {
            if (!string.IsNullOrWhiteSpace(item.Codi) && item.Preu > 0)
                return Ok(_is.AddItem(item));
            else
                return BadRequest("Item is not valid");
        }

        /// <summary>
        /// Actualitzar un ítem
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [Route("Items")]
        [HttpPut]
        public IHttpActionResult updateItem(ItemDTO item)
        {
            if (item.Id > 0 && !string.IsNullOrWhiteSpace(item.Codi) && item.Preu > 0)
                return Ok(_is.UpdateItem(item));
            else
                return BadRequest("Item is not valid");
        }

        /// <summary>
        /// Esborrar un ítem
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Items")]
        [HttpDelete]
        public IHttpActionResult deleteItem(int id)
        {
            return Ok(_is.DeleteItem(id));
        }
    }
}