using System.Linq;
using System.Collections.Generic;

namespace clases.Models

{
    public partial class Cliente
    {
        public int Id {get; set;}
        public string Dni_cliente {get; set;}
        public string Nombre_cliente {get; set;}
        public string Direccion_cliente {get; set;}
        public string Telefono_cliente {get; set;}
    }

}
