using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Entities
{
    public class Cliente
    {

        [Key] 

        //QAMAOLADlD
        public int PkCliente { get; set; }

        public string NombreCliente { get; set; }

        public string ApellidoC { get; set; }

        public string CorreoCliente { get; set; }

        public string PasswordCliente { get; set; }

        public double SaldoCliente { get; set; }


    }
}
