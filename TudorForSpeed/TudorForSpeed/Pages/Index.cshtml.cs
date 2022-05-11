using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TudorForSpeed.Data;
using TudorForSpeed.Helper;

namespace TudorForSpeed.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<CarOrder> Show = new List<CarOrder>();
        public async Task<IActionResult> OnGetAsync()
        {
            var post = APIForSpeed_API.GetAllOrders().Result.ToList();
            Show = post;
            return Page();
        } 

    }
}
