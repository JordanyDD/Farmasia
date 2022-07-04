using System.ComponentModel.DataAnnotations;

namespace Farmasia.Models
{
    public class Commande
    {
        public string CommandeID { get; set; } = string.Empty;
        public string NumFacture { get; set; } = string.Empty;
        public bool LivState { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLivraison { get; set; }



        //navigation properties
        public ICollection<SProduit>? SProduits { get; set; }

      //  public List<CommandeSProduit>? CommandeSProduits { get; set; }

    }
}
