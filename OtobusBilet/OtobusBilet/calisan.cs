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
    
    public partial class calisan
    {
        public calisan()
        {
            this.bilet = new HashSet<bilet>();
            this.calisanKullanici = new HashSet<calisanKullanici>();
            this.seferCalisan = new HashSet<seferCalisan>();
        }
    
        public int calisanID { get; set; }
        public int calisanPozisyonID { get; set; }
        public int subeID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public System.DateTime dogumTarihi { get; set; }
        public string ehliyetSinifi { get; set; }
        public Nullable<System.DateTime> ehliyetAlisTarihi { get; set; }
        public string telefon { get; set; }
        public string mail { get; set; }
        public int adresID { get; set; }
        public System.DateTime girisTarihi { get; set; }
        public Nullable<System.DateTime> cikisTarihi { get; set; }
        public decimal maas { get; set; }
        public bool durum { get; set; }
        public string calisanTCKNO { get; set; }
    
        public virtual adres adres { get; set; }
        public virtual ICollection<bilet> bilet { get; set; }
        public virtual calisanPozisyon calisanPozisyon { get; set; }
        public virtual ICollection<calisanKullanici> calisanKullanici { get; set; }
        public virtual ICollection<seferCalisan> seferCalisan { get; set; }
        public virtual sube sube { get; set; }
    }
}
