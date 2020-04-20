using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgendaAspNet.Models;

namespace AgendaAspNet.Pages.Contatos
{
    public class IndexModel : PageModel
    {
        private readonly AgendaAspNet.Models.AppDbConnection _context;

        public IndexModel(AgendaAspNet.Models.AppDbConnection context)
        {
            _context = context;
        }

        public IList<Contato> Contato { get;set; }

        public async Task OnGetAsync()
        {
            Contato = await _context.Contatos.ToListAsync();
        }
    }
}
