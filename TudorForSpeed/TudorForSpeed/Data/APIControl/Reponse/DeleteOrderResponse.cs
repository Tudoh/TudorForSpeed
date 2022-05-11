using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TudorForSpeed.Data.APIControl.Reponse
{
    public class DeleteOrderResponse : DefaultResponse
    {
        public CarOrder DeleteOrder { get; set; }
    }
}
