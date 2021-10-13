using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Saludtotal.Domain.Entities
{
    public class Aplicativo
    {

        public int AplicativoID { get; set; }
        
        public int DesarrolladorID { get; set; }

        public string NombreAplicativo { get; set; }
        
        public int DiasDesarrollo {get; set; }
        
        public DateTime FechaDesarrollo {get;  set; }
    }
}
