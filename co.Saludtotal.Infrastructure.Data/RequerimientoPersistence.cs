using co.Saludtotal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace co.Saludtotal.Infrastructure.Data
{
    public static class RequerimientoPersistence
    {

        public static DataTable GetAllRequerimientos()
        {

            if (Conexion.EjecutarConsulta("Getrequerimientoall", CommandType.StoredProcedure).Rows.Count > 0)
            {
                return Conexion.EjecutarConsulta("Getrequerimientoall", CommandType.StoredProcedure);
            }
            else
            {
                return null;
            }
        }

        public static void CreateRequerimiento(Requerimiento oRequerimiento)
        {
            List<SqlParameter> listaInsertar = new List<SqlParameter>();

            SqlParameter NombreRequerimiento = new SqlParameter("@NombreRequerimiento", oRequerimiento.NombreRequerimiento);
            SqlParameter AlcanceRequerimiento = new SqlParameter("@AlcanceRequerimiento", oRequerimiento.AlcanceRequerimiento);
            SqlParameter FechaSolicitud = new SqlParameter("@FechaSolicitud", oRequerimiento.FechaSolicitud);
            SqlParameter AplicativoID = new SqlParameter(" @AplicativoID", oRequerimiento.AplicativoID);

            listaInsertar.Add(NombreRequerimiento);
            listaInsertar.Add(AlcanceRequerimiento);
            listaInsertar.Add(FechaSolicitud);
            listaInsertar.Add(AplicativoID);

            Conexion.EjecutarOperacion("insertRequerimiento", listaInsertar, CommandType.StoredProcedure);

        }

        public static void UpdateRequerimiento(Requerimiento oRequerimiento)
        {
            List<SqlParameter> listaUpdate = new List<SqlParameter>();

            SqlParameter NombreRequerimiento = new SqlParameter("@NombreRequerimiento", oRequerimiento.NombreRequerimiento);
            SqlParameter AlcanceRequerimiento = new SqlParameter("@AlcanceRequerimiento", oRequerimiento.AlcanceRequerimiento);
            SqlParameter FechaSolicitud = new SqlParameter("@FechaSolicitud", oRequerimiento.FechaSolicitud);
            SqlParameter AplicativoID = new SqlParameter(" @AplicativoID", oRequerimiento.AplicativoID);

            listaUpdate.Add(NombreRequerimiento);
            listaUpdate.Add(AlcanceRequerimiento);
            listaUpdate.Add(FechaSolicitud);
            listaUpdate.Add(AplicativoID);

            Conexion.EjecutarOperacion("updaterequerimiento", listaUpdate, CommandType.StoredProcedure);

        }

        public static void DeleteRequerimiento(Requerimiento oRequerimiento)
        {
            List<SqlParameter> lista = new List<SqlParameter>();
            SqlParameter codigo = new SqlParameter("@id", oRequerimiento.RequerimientoID);

            lista.Add(codigo);

            Conexion.EjecutarOperacion("RequerimientoDelete", lista, CommandType.StoredProcedure);
        }
    }
}
