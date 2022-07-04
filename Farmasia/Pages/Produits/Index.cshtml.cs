using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farmasia.Data;
using Farmasia.Models;

namespace Farmasia.Pages.Produits
{
    public class IndexModel : PageModel
    {
        private readonly Farmasia.Data.FarmasiaContext _context;

        public IndexModel(Farmasia.Data.FarmasiaContext context)
        {
            _context = context;
        }

        public IList<Produit> Produit { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Produit != null)
            {
                Produit = await _context.Produit.ToListAsync();
            }
        }
    }
}
