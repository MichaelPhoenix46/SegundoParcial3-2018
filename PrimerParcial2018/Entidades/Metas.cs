using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial2018.Entidades
{
    public class Metas
    {
        [Key]
        public int MetasId { get; set; }
        public string Descripcion { get; set; }
        public decimal Cuotas { get; set; }

        public Metas()
        {
            MetasId = 0;
            Descripcion = string.Empty;
            Cuotas = 0;
        }
    }
}
