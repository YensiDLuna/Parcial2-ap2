using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Parcial2_ap2.Models
{
    public class Clientes
    {
            [Key]
            public int ClienteId { get; set; }
            public string Nombre { get; set; }
    }
}
