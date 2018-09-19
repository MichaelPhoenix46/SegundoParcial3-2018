using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial2018.Entidades
{
    public class Vendedores
    {
        [Key]
        public int Vendedorid { get; set; }
        public string Nombres { get; set; }
        public decimal Sueldo { get; set; }
        public decimal PorRetencion { get; set; }
        public decimal Retencion { get; set; }
        public DateTime Fecha { get; set; }

        public Vendedores()
        {
            Vendedorid = 0;
            Nombres = string.Empty;
            Sueldo = 0;
            PorRetencion = 0;
            Retencion = 0;
            Fecha = DateTime.Now;
        }

    }
}
