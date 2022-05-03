using APIForSpeed.Models;
using APIForSpeed.Models.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIForSpeed.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarOrderController : ControllerBase
    {
        public CarOrderController(ICarOrder order)
        {
            _Order = order;
        }
        public ICarOrder _Order { get; set; }

        [HttpPost("/Create")]
        public CarOrderClass AddCarList([FromBody] CarOrderClass NewOrder)
        {
                _Order.Create(NewOrder);
                return NewOrder;
        }

        [HttpGet]
        public IList<CarOrderClass> LoadCarOrderList()
        {
            return _Order.SeeAllOrders();
        }

        [Swashbuckle.AspNetCore.Annotations.SwaggerOperation(Summary = "Cerca Ordine")]
        [HttpGet("/SearchOrders {ID}")]
        public IActionResult GetOrder(int ID)
        {
            var item = _Order.FindByID(ID);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPut("/UpdateOrder {ID}")]
        public void Put(int id, [FromBody] CarOrderClass modal)
        {
            _Order.Update(id, modal);
        }

        [Swashbuckle.AspNetCore.Annotations.SwaggerOperation(Summary = "You can Use ID for delete a order on database")]
        [HttpDelete("/DeleteCarOrder {ID}")]
        public IEnumerable<CarOrderClass> DeleteOrder(int ID)
        {
            _Order.Delete(ID);
            return _Order.SeeAllOrders();
        }
    }
}
