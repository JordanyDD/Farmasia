using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Farmasia.Pages
{
    public class SProduitsModel : PageModel
    {
        private readonly Farmasia.Data.FarmasiaContext _context;

        public SProduitsModel(Farmasia.Data.FarmasiaContext context)
        {
            _context = context;
        }
        
        public List<Farmasia.Models.SProduit>? SProduits { get; set; }
        public void OnGet()
        {
            if(_context.SProduit != null)
            {
                SProduits =  _context.SProduit.ToList();
            }
            else { }
        }
    }
}
