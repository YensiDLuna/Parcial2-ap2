using Microsoft.EntityFrameworkCore;
using Parcial2_ap2.DAL;
using Parcial2_ap2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial2_ap2.BLL
{
    public class VentasBLL
    {
        public static List<Ventas> GetList(Expression<Func<Ventas, bool>> criterio)
        {
            List<Ventas> list = new List<Ventas>();
            Contexto contexto = new Contexto();

            try
            {
                list = contexto.Ventas.Where(criterio).AsNoTracking().ToList();
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }

            return list;
        }
    }
}
