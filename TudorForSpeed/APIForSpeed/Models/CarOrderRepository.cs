using APIForSpeed.Models.DBContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIForSpeed.Models
{
    public class CarOrderRepository : ICarOrder
    {

        private readonly APIDBContext _context;

        public CarOrderRepository(APIDBContext context)
        {
            _context = context;
        }

        public void Create(CarOrderClass NewOrder)
        {
            _context.List_CarOrder.Add(NewOrder);
            _context.SaveChanges();
        }

        public CarOrderClass FindByID(int ID)
        {
            return _context.List_CarOrder.FirstOrDefault(x => x.OrderID == ID);
        }

        public List<CarOrderClass> SeeAllOrders()
        {
            return _context.List_CarOrder.ToList();
        }
        public void Delete(int ID)
        {
            var FoundOrder = _context.List_CarOrder.Find(ID);
            if (FoundOrder == null)
            {
                return;
            }
            _context.List_CarOrder.Remove(FoundOrder);
            _context.SaveChanges();
        }

    }
}
