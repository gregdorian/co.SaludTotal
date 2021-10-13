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
    public class AplicativoService
    {
        public static List<Aplicativo> ConsultarAplicativo()
        {

            DataTable dtAplicativo;
            dtAplicativo = AplicativoPersistence.GetAllAplicativo();

            List<Aplicativo> lstAplicativo = ConvertUtility.ConvertDataTable<Aplicativo>(dtAplicativo);

            return lstAplicativo;
        }

        public static bool RegistrarAplicativo(Aplicativo oAplicativo)
        {
            try
            {

                AplicativoPersistence.CreateAplicativo(oAplicativo);
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
            }

        }

        public static bool ActualizarAplicativo(Aplicativo oAplicativo)
        {
            try
            {

                AplicativoPersistence.UpdateAplicativo(oAplicativo);
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw ex;
            }

        }

        public static bool BorrarAplicativo(Aplicativo oAplicativo)
        {
            try
            {

                AplicativoPersistence.DeleteAplicativo(oAplicativo);
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
