using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TudorForSpeed.Data;
using TudorForSpeed.Data.APIControl;
using TudorForSpeed.Helper;

namespace TudorForSpeed.Pages
{
    [Authorize]
    public class OrderModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public OrderModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public CarOrder Ordine { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            var post = await APIForSpeed_API.CreateOrder(new CreateOrderRequest { OrderID = Ordine.OrderID, Name = Ordine.Name, Surname = Ordine.Surname, Modello = Ordine.Modello,Email = Ordine.Email, Phone = Ordine.Phone, DataOrdine = DateTime.Now, Prezzo = Ordine.Prezzo});

            return Redirect("./Index");

        }

    }
}
