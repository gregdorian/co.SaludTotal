using co.Saludtotal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace co.Saludtotal.Infrastructure.Data
{
    public static class AplicativoPersistence
    {
        public static DataTable GetAllAplicativo()
        {

            if (Conexion.EjecutarConsulta("GetAplicativoall", CommandType.StoredProcedure).Rows.Count > 0)
            {
                return Conexion.EjecutarConsulta("GetAplicativoall", CommandType.StoredProcedure);
            }
            else
            {
                return null;
            }
        }

        public static void CreateAplicativo(Aplicativo oAplicativo)
        {
            List<SqlParameter> listaInsertar = new List<SqlParameter>();

            SqlParameter DesarrolladorID = new SqlParameter(" @AplicativoID", oAplicativo.DesarrolladorID);
            SqlParameter NombreAplicativo = new SqlParameter("@NombreAplicativo", oAplicativo.NombreAplicativo);
            SqlParameter DiasDesarrollo = new SqlParameter("@DiasDesarrollo", oAplicativo.DiasDesarrollo);
            SqlParameter FechaDesarrollo = new SqlParameter("@FechaDesarrollo", oAplicativo.FechaDesarrollo);

            listaInsertar.Add(DesarrolladorID);
            listaInsertar.Add(NombreAplicativo);
            listaInsertar.Add(DiasDesarrollo);
            listaInsertar.Add(FechaDesarrollo);

            Conexion.EjecutarOperacion("insertaplicativo", listaInsertar, CommandType.StoredProcedure);

        }

        public static void UpdateAplicativo(Aplicativo oAplicativo)
        {
            List<SqlParameter> listaUpdate = new List<SqlParameter>();


            SqlParameter DesarrolladorID = new SqlParameter(" @AplicativoID", oAplicativo.DesarrolladorID);
            SqlParameter NombreAplicativo = new SqlParameter("@NombreAplicativo", oAplicativo.NombreAplicativo);
            SqlParameter DiasDesarrollo = new SqlParameter("@DiasDesarrollo", oAplicativo.DiasDesarrollo);
            SqlParameter FechaDesarrollo = new SqlParameter("@FechaDesarrollo", oAplicativo.FechaDesarrollo);

            listaUpdate.Add(DesarrolladorID);
            listaUpdate.Add(NombreAplicativo);
            listaUpdate.Add(DiasDesarrollo);
            listaUpdate.Add(FechaDesarrollo);

            Conexion.EjecutarOperacion("updateaplicativo", listaUpdate, CommandType.StoredProcedure);

        }

        public static void DeleteAplicativo(Aplicativo oAplicativo)
        {
            List<SqlParameter> lista = new List<SqlParameter>();
            SqlParameter codigo = new SqlParameter("@id", oAplicativo.AplicativoID);

            lista.Add(codigo);

            Conexion.EjecutarOperacion("deleteaplicativo", lista, CommandType.StoredProcedure);
        }
    }
}
