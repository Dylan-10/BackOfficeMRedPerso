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
    
    public partial class SerieLangue
    {
        public int SerieLangueId { get; set; }
        public int SerieId { get; set; }
        public int LangueId { get; set; }
        public string Libelle { get; set; }
        public string ImageLien { get; set; }
        public string SEOCourt { get; set; }
        public string SEOLong { get; set; }
        public string Description { get; set; }
        public string ContenuHTML { get; set; }
    
        public virtual Langue Langue { get; set; }
        public virtual Serie Serie { get; set; }
    }
}
