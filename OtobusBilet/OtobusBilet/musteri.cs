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
    
    public partial class musteri
    {
        public musteri()
        {
            this.bilet = new HashSet<bilet>();
            this.koltuk = new HashSet<koltuk>();
        }
    
        public int musteriID { get; set; }
        public string kadi { get; set; }
        public string pass { get; set; }
        public string tckn { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public System.DateTime dogumTarihi { get; set; }
        public System.DateTime kayitTarihi { get; set; }
        public string cepTelefonu { get; set; }
        public string evTelefonu { get; set; }
        public string eposta { get; set; }
        public int adresID { get; set; }
        public int puan { get; set; }
        public bool durum { get; set; }
    
        public virtual adres adres { get; set; }
        public virtual ICollection<bilet> bilet { get; set; }
        public virtual ICollection<koltuk> koltuk { get; set; }
    }
}
