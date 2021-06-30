using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_ap2.Models
{
    public class Ventas
    {
    [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }
    }
}
