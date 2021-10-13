using co.Saludtotal.Domain.Core;
using co.Saludtotal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Saludtotal.Aplication
{
    public class RequerimientosFac
    {
        public RequerimientosFac()
        {

        }

        public List<Requerimiento> GetAll()
        {

            try
            {
                return RegistrarRequerimientos.ConsultarRequerimiento();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Create(Requerimiento oReq)
        {

            try
            {
              return  RegistrarRequerimientos.RegistrarRequerimiento(oReq);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(Requerimiento oReq)
        {

            try
            {
                RegistrarRequerimientos.ActualizarRequerimiento(oReq);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Delete(Requerimiento oReq)
        {
            try
            {
                RegistrarRequerimientos.BorrarRequerimiento(oReq);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Aplicativo> GetAplicativo()
        {
            try
            {
                return  AplicativoService.ConsultarAplicativo();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
