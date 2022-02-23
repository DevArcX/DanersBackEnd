using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class personaModels
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdTipoDoc { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdRolPersona { get; set; }
        public int IdDireccion { get; set; }
        public int IdTelefono { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
    }
}
