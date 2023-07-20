using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public  class Sabor
    {

        [Key]
        public int PkSabor { get; set; } 

        public string NombreSabor { get; set; }



    }
}
