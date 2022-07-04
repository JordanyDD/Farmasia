namespace Farmasia.Models
{
    public class SProduit
    {
        public string SProduitID { get; set; } = string.Empty;
        public string Design { get; set; } = string.Empty;
        public decimal PU { get; set; }
        public int QTE { get; set; }
        public string Type { get; set; } = string.Empty;

        public string SProduitIDa { get; set; } = string.Empty;


        //NAVIGATION PROPERTIES
        public ICollection<Commande>? Commandes { get; set; }

        public ICollection<Fournisseur>? Fournisseurs { get; set; }
    }
}
    /*

        namespace Farmasia.Models
    {
        public class FournisseurSProduit
        {
            public Fournisseur? Fournisseur { get; set; }
            public string FournisseursFournisseurID { get; set; } = string.Empty;
            public SProduit? SProduit { get; set; }
            public string SProduitsSProduitID { get; set; } = string.Empty;


            //additional Data required when custom Join entity type
            public decimal CPrix { get; set; }
        }
    }


    namespace Farmasia.Models
    {



        public class CommandeSProduit
        {
            //commande side
            public Commande? Commande { get; set; }
            public string CommandesCommandeID { get; set; } = string.Empty;

            //SProdui side
            public SProduit? Sproduit { get; set; }
            public string SProduitsSProduitID { get; set; } = string.Empty;


            //AdD
            public int QTE { get; set; }
        }
    }

    // public List<CommandeSProduit>? CommandeSProduits { get; set; }
    //        public List<FournisseurSProduit>? FournisseurSProduits { get; set; }
}
}
    */