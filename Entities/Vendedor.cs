using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public class Vendedor
    {
        [Key] 
        public int PkVendedor { get; set; }

        public string NombreVendedor { get; set; }

        public string ApellidoVendedor { get; set; }

        public string CorreoVendedor { get; set; }

        public string PasswordVendedor { get; set; }

    }
}
