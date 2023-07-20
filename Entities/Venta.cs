using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public class Venta
    {

        public int PkVenta { get; set; }

        public DateTime FechaCompra { get; set; }

        [ForeignKey("Clientes")]

        public int? FkCliente { get; set; }

        public Cliente Clientes { get; set; }

        [ForeignKey("Vendedores")]

        public int? FkVendedor { get; set; }

        public Vendedor Vendedores { get; set; }


    }
}
