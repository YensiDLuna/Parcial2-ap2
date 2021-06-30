using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial2_ap2.DAL;
using Parcial2_ap2.Models;
namespace Parcial2_ap2.BLL
{
    public class ClienteBLL
    {
        public static List<Clientes> GetList(Expression<Func<Clientes, bool>> criterio)
        {
            List<Clientes> list = new List<Clientes>();
            Contexto contexto = new Contexto();

            try
            {
                list = contexto.Clientes.Where(criterio).AsNoTracking().ToList();
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

