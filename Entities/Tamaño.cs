﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public class Tamaño
    {
        [Key] 
        
        public int PkTamaño { get; set; }

        public string TamañoProducto { get; set; }

    }
}
