﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial2018.BLL
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> expression);
        T Buscar(int Id);
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool ELiminar(int id);
    }
}
