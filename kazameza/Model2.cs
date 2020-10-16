namespace kazameza
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Sku)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.WholesalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SouqPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SellerPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.MinPrice)
                .HasPrecision(19, 4);
        }
    }
}
