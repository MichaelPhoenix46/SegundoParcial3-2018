using PrimerParcial2018.DAL;
using PrimerParcial2018.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial2018.BLL
{
    public class VendedoresBLL
    {
        public static bool Guardar(Vendedores vendedores)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Vendededores.Add(vendedores)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Vendedores vendedores = contexto.Vendededores.Find(id);
                if(vendedores !=null)
                {
                    contexto.Entry(vendedores).State = EntityState.Deleted;
                }

                if(contexto.SaveChanges()>0)
                {
                    paso = true;
                    contexto.Dispose();
                }
            }
            catch(Exception)
            {
                throw;
            }


            return paso;
        }

        public static bool Modificar(Vendedores vendedores)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {


                contexto.Entry(vendedores).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Vendedores Buscar(int id)
        {
            Vendedores vendedores = new Vendedores();
            Contexto contexto = new Contexto();
            try
            {
                vendedores = contexto.Vendededores.Find(id);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return vendedores;




        }

        public static List<Vendedores> GetList(Expression<Func<Vendedores, bool>> expression)
        {
            List<Vendedores> vendedores = new List<Vendedores>();
            Contexto contexto = new Contexto();

            try
            {
                vendedores = contexto.Vendededores.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return vendedores;
        }
                    
        public static decimal CalculoRetencion(decimal sueldo, decimal retencion)
        {
           return sueldo * (retencion/100);

        }


    }



    
}
