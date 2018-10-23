using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial2018.Entidades
{
    public class MetasDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public string Descripcion { get; set; } 
        public decimal Cuota { get; set; }
        public int Vendedorid { get; set; }
        public int MetasId { get; set; }

        public MetasDetalle()
        {
            DetalleId = 0;
            Descripcion = string.Empty;
            Cuota = 0;
            Vendedorid = 0;
            MetasId = 0;
        }

        public MetasDetalle(int detallesid,int metaid,int vendedorid, decimal cuota)
        {
            this.DetalleId = detallesid;
            this.MetasId = metaid;
            this.Vendedorid = vendedorid;
            Cuota = cuota;
        }
    }
}
