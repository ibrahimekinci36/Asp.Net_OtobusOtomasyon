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
    
    public partial class guzergah
    {
        public guzergah()
        {
            this.guzergahDurak = new HashSet<guzergahDurak>();
            this.guzergahMola = new HashSet<guzergahMola>();
            this.sefer = new HashSet<sefer>();
        }
    
        public int guzergahID { get; set; }
        public string ad { get; set; }
        public string aciklama { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
        public Nullable<bool> durum { get; set; }
    
        public virtual ICollection<guzergahDurak> guzergahDurak { get; set; }
        public virtual ICollection<guzergahMola> guzergahMola { get; set; }
        public virtual ICollection<sefer> sefer { get; set; }
    }
}
