namespace Farmasia.Models
{
    public class Fournisseur
    {
        public string FournisseurID { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Adresse { get; set; } = string.Empty;

        //nav ppties

        public ICollection<SProduit>? SProduits { get; set; }
       // public List<FournisseurSProduit>? FournisseurSProduits { get; set; }

    }
}
