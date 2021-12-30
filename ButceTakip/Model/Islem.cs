namespace ButceTakip.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Islem")]
    public partial class Islem
    {
        public int islemID { get; set; }

        public int? islemTurID { get; set; }

        [StringLength(500)]
        public string aciklama { get; set; }

        [Column(TypeName = "money")]
        public decimal? tutar { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        public int? kullaniciID { get; set; }

        public virtual IslemTur IslemTur { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
