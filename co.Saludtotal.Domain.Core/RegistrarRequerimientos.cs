using co.Saludtotal.Domain.Entities;
using co.Saludtotal.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace co.Saludtotal.Domain.Core
{
    public static class RegistrarRequerimientos
    {

        public static List<DataRow> ConsultarRequerimiento()
        {

            DataTable dtConsultaFactura;
            dtConsultaFactura = RequerimientoPersistence.GetAllRequerimientos();

            List<DataRow> lstClientes = dtConsultaFactura.AsEnumerable().ToList();

            return lstClientes;
        }


        public static bool RegistrarRequerimiento(Requerimiento oRequerimiento)
        {
            try
            {

                RequerimientoPersistence.CreateRequerimiento(oRequerimiento);
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
            }

        }

        public static bool ActualizarRequerimiento(Requerimiento oRequerimiento)
        {
            try
            {

                RequerimientoPersistence.UpdateRequerimiento(oRequerimiento);
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
            }

        }

        public static bool BorrarRequerimiento(Requerimiento oRequerimiento)
        {
            try
            {

                RequerimientoPersistence.DeleteRequerimiento(oRequerimiento);
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
            }

        }


    }
}
