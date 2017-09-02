namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cliente")]
    public partial class cliente
    {
        [Key]
        public int id_cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_cliente { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_paterno { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_materno { get; set; }
    }
}
