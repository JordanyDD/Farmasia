using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Farmasia.Data;
using Farmasia.Models;

namespace Farmasia.Pages
{
    public class CommandesModel : PageModel
    {
        private readonly FarmasiaContext _context;
        public CommandesModel(FarmasiaContext context)
        {
            _context = context;
        }

        public List<Commande>? CommandeList { get; set; } = default!;

        public void OnGet()
        {
            CommandeList = _context.Commande.ToList();
        }
    }
}
