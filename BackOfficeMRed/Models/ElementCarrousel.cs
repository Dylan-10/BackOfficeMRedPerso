//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackOfficeMRed.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ElementCarrousel
    {
        public int ElementCarrouselId { get; set; }
        public int LangueId { get; set; }
        public string Libelle { get; set; }
        public string Titre { get; set; }
        public string Contenu { get; set; }
        public string TexteBouton { get; set; }
        public string LienBouton { get; set; }
        public string LienImage { get; set; }
    
        public virtual Langue Langue { get; set; }
    }
}
