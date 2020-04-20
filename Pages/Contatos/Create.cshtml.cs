using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AgendaAspNet.Models;

namespace AgendaAspNet.Pages.Contatos
{
    public class CreateModel : PageModel
    {
        private readonly AgendaAspNet.Models.AppDbConnection _context;

        public CreateModel(AgendaAspNet.Models.AppDbConnection context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Contato Contato { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Contatos.Add(Contato);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
