//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtobusBiletSatis
{
    using System;
    using System.Collections.Generic;
    
    public partial class molaTesis
    {
        public molaTesis()
        {
            this.guzergahMola = new HashSet<guzergahMola>();
        }
    
        public int molaTesisID { get; set; }
        public string ad { get; set; }
        public int adresID { get; set; }
        public string aciklama { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public bool durum { get; set; }
    
        public virtual adres adres { get; set; }
        public virtual ICollection<guzergahMola> guzergahMola { get; set; }
    }
}