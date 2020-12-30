using Exercicis.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Exercicis.Controllers
{
    /// <summary>
    /// Controlador de comandes
    /// </summary>
    public class OrderController : ApiController
    {
        private readonly IOrderService _os;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="orderService"></param>
        public OrderController(IOrderService orderService) { _os = orderService; }

        /// <summary>
        /// Obtindre la llista de les comandes
        /// </summary>
        /// <param name="refNumber">Filtrar per referència</param>
        /// <param name="quan">Filtrar per data</param>
        /// <returns></returns>
        [Route("Comandes")]
        [HttpGet]
        public IHttpActionResult GetComandes(string refNumber, DateTime? quan)
        {
            return Ok(_os.GetComandes(refNumber, quan));
        }

        /// <summary>
        /// Obtindre una comanda
        /// </summary>
        /// <param name="id">Identificador de la comanda</param>
        /// <returns></returns>
        [Route("Comandes/id")]
        [HttpGet]
        public IHttpActionResult GetComanda(int id)
        {
            return Ok(_os.GetComanda(id));
        }
    }
}