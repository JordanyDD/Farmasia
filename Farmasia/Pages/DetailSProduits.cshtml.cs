using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farmasia.Data;
using Farmasia.Models;

namespace Farmasia.Pages
{
    public class DetailSProduitsModel : PageModel
    {
        private readonly FarmasiaContext _context;
        public DetailSProduitsModel(FarmasiaContext context)
        {
            _context = context;
        }
        public SProduit SProduit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string? id)
        {
           /* if (id == null || _context.Produit == null)
            {
                return NotFound();
            } */

            var sproduit = await _context.SProduit.FirstOrDefaultAsync(m => m.SProduitID == id);
            /*if (produit == null)
            {
                return NotFound();
            }
            else
            {*/
                SProduit = sproduit;
           // }
            return Page();
        }



    }
}
