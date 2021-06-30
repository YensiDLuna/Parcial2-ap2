﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_ap2.DAL
{
    public class Contexto: DbContext
    {
      

      

  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 1, Nombres = "FERRETERIA GAMA" });
                modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 1, Fecha = new DateTime(2020, 09, 01), ClienteId = 1, Monto = 1000, Balance = 1000 });
                modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 2, Fecha = new DateTime(2020, 10, 01), ClienteId = 1, Monto = 900, Balance = 800 });
                modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 2, Nombres = "AVALON DISCO" });
                modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 3, Fecha = new DateTime(2020, 09, 01), ClienteId = 2, Monto = 2000, Balance = 2000 });
                modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 4, Fecha = new DateTime(2020, 10, 01), ClienteId = 2, Monto = 1900, Balance = 1800 });
                modelBuilder.Entity<Clientes>().HasData(new Clientes() { ClienteId = 3, Nombres = "PRESTAMOS CEFIPROD" });
                modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 5, Fecha = new DateTime(2020, 09, 01), ClienteId = 3, Monto = 3000, Balance = 3000 });
                modelBuilder.Entity<Ventas>().HasData(new Ventas() { VentaId = 6, Fecha = new DateTime(2020, 10, 01), ClienteId = 3, Monto = 2900, Balance = 1900 });

            }


        }

}
}


