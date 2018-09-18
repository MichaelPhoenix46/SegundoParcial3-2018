using PrimerParcial2018.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial2018.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedores> Vendededores { get; set; }
        public Contexto() : base("ConStr")
        { }
    }

}
