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
        public static List<CobrosDetalle> ObetenerVentasPendientes(int ClienteId)
        {
            var ListaPendientes = new List<CobrosDetalle>();
            Contexto contexto = new Contexto();

            try
            {
                var pendientes = contexto.Ventas
                    .Where(e => e.ClienteId == ClienteId && e.Balance > 0)
                    .AsNoTracking()
                    .ToList();

                foreach (var item in pendientes)
                {
                    ListaPendientes.Add(new CobrosDetalle
                    {
                        VentaId = item.VentasId,
                        Venta = item,
                        Total = 0
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ListaPendientes;
        }
    }
}
