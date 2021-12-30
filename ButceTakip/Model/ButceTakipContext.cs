using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ButceTakip.Model
{
    public partial class ButceTakipContext : DbContext
    {
        public ButceTakipContext()
            : base("name=ButceTakipContext")
        {
        }

        public virtual DbSet<Islem> Islem { get; set; }
        public virtual DbSet<IslemTur> IslemTur { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Islem>()
                .Property(e => e.tutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Yetki>()
                .Property(e => e.ad)
                .IsFixedLength();
        }
    }
}
