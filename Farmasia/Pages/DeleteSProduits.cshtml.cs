using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farmasia.Data;
using Farmasia.Models;


namespace Farmasia.Pages
{
    public class DeleteSProduitsModel : PageModel
    {

        private readonly Farmasia.Data.FarmasiaContext _context;

        public DeleteSProduitsModel(Farmasia.Data.FarmasiaContext context)
        {
            _context = context;
        }
        [BindProperty]
        public SProduit SProduit { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(string? id)
        {
            if (id == null || _context.SProduit == null)
            {
                return NotFound();
            }

            var produit = await _context.SProduit.FirstOrDefaultAsync(m => m.SProduitID == id);

            if (produit == null)
            {
                return NotFound();
            }
            else
            {
                SProduit = produit;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(string? id)
        {
            if (id == null || _context.SProduit == null)
            {
                return NotFound();
            }
            var produit = await _context.SProduit.FindAsync(id);

            if (produit != null)
            {
                SProduit = produit;
                _context.SProduit.Remove(SProduit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/SProduits");
        }
    }
}
