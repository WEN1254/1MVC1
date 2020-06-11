namespace MVC.Models.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public int BuyAmount { get; set; }

        [Required]
        public string BuyPrice { get; set; }

        public int ProductSpecificationID { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderIShelveDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ProductSpecification ProductSpecification { get; set; }
    }
}
