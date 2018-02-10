namespace Carrito.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Producto")]
    public partial class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        public decimal? precio { get; set; }

        public int? stock { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaAlta { get; set; }

        public int? idCatalogo { get; set; }
    }
}
