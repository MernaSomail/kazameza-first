namespace kazameza
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [Key]
        public int OfferID { get; set; }

        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(100)]
        public string EAN { get; set; }

        [StringLength(100)]
        public string Sku { get; set; }

        [Column(TypeName = "image")]
        public byte[] Img { get; set; }

        public int? Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public double? SouqPS { get; set; }

        public double? SellerPS { get; set; }

        [Column(TypeName = "money")]
        public decimal? WholesalePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SouqPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? SellerPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinPrice { get; set; }

        public int? CategoryType { get; set; }
    }
}
