using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TudorForSpeed.Data.APIControl.Request
{
    public class DeleteOrderRequest : DefaultResponse
    {
        [Required]
        public int id_Order { get; set; }
    }
}
