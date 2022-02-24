using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Rol_Persona")]
    public class rolPersonaModels
    {
        [key]
        public int id { get; set; }
        public string Rol { get; set; }
    }
}
