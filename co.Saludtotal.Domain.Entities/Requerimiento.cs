using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Saludtotal.Domain.Entities
{
    public class Requerimiento
    {

            public int RequerimientoID { get; set; }

            public string NombreRequerimiento { get; set; }

            public string AlcanceRequerimiento { get; set; }

            public DateTime FechaSolicitud { get; set;}

            public int AplicativoID { get; set; }

    }
}
