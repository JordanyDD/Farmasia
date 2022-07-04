using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Farmasia.Data;
using Farmasia.Models;

namespace Farmasia.Pages
{
    public class CreateSProduitsModel : PageModel
    {
        private readonly Farmasia.Data.FarmasiaContext _context;

        public CreateSProduitsModel(Farmasia.Data.FarmasiaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SProduit SProduit { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            

            _context.SProduit.Add(SProduit);
            await _context.SaveChangesAsync();

            return RedirectToPage("/SProduits");
        }
    }
}
