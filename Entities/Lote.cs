﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public class Lote
    {
        [Key]
        
        public int PkLote { get; set; }

        public string LoteName {get; set; }


    }
}
