//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resotel.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class rate
    {
        public int rate_id { get; set; }
        public int rate_days_number { get; set; }
        public float rate_price { get; set; }
        public int bedroom_type_id { get; set; }
    
        public virtual bedroom_type bedroom_type { get; set; }
    }
}
