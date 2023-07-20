using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public class Producto
    {
        [Key]
        public int PkProducto { get; set; }

        public string NombreProducto { get; set; }

        public int CantidadProducto { get; set; }

      [ForeignKey("Sabores")] 

      public int? FkSabor { get; set; }

        public Sabor Sabores { get; set; }

        [ForeignKey("Tamaños")]

        public int FkTamaño { get; set; }

        public Tamaño Tamaños { get; set; }

        [ForeignKey("Lotes")] 

        public int? FkLote { get; set; }

        public Lote Lotes { get; set; }

        

    }
}
