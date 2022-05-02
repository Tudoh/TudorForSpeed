using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIForSpeed.Models
{
    public interface ICarOrder
    {
        void Create(CarOrderClass NewOrder);
        CarOrderClass FindByID(int ID);
        List<CarOrderClass> SeeAllOrders();
        void Update(int id, CarOrderClass item);
        void Delete(int id);
    }
}
