namespace EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        public int Po { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Quantity { get; set; }

        public int? Price { get; set; }

        [StringLength(50)]
        public string Category { get; set; }
    }
}
