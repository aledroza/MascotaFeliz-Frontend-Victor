using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MascotaFelizWeb.App.Frontend.Pages
{
    public class AgendamientoModel : PageModel
    {
        private readonly ILogger<AgendamientoModel> _logger;

        public AgendamientoModel(ILogger<AgendamientoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
  