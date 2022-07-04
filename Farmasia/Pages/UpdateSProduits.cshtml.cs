using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Farmasia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Farmasia.Data;


namespace Farmasia.Pages
{
    public class UpdateSProduitsModel : PageModel
    {
        private readonly FarmasiaContext _context;

        public UpdateSProduitsModel(FarmasiaContext context)
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
            SProduit = produit;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SProduit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduitExists(SProduit.SProduitID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/SProduits");
        }

        private bool ProduitExists(string id)
        {
            return (_context.SProduit?.Any(e => e.SProduitID == id)).GetValueOrDefault();
        }

    }
}
