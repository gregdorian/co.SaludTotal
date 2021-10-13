using co.Saludtotal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace co.Saludtotal.Infrastructure.Data
{
    public static class DesarrolladorPersistence
    {

        public static DataTable GetAllDesarrollador()
        {

            if (Conexion.EjecutarConsulta("GetDesarrolladorAll", CommandType.StoredProcedure).Rows.Count > 0)
            {
                return Conexion.EjecutarConsulta("GetDesarrolladorAll", CommandType.StoredProcedure);
            }
            else
            {
                return null;
            }
        }

        public static void CreateDesarrollador(Desarrollador oDesarrollador)
        {
            List<SqlParameter> listaInsertar = new List<SqlParameter>();

            SqlParameter NombreDesarrollador = new SqlParameter("@NombreDesarrollador", oDesarrollador.NombreDesarrollador);

            listaInsertar.Add(NombreDesarrollador);

            Conexion.EjecutarOperacion("insertDesarrollador", listaInsertar, CommandType.StoredProcedure);

        }

        public static void UpdateDesarrollador(Desarrollador oDesarrollador)
        {
            List<SqlParameter> listaUpdate = new List<SqlParameter>();

            SqlParameter NombreDesarrollador = new SqlParameter("@NombreDesarrollador", oDesarrollador.NombreDesarrollador);

            listaUpdate.Add(NombreDesarrollador);

            Conexion.EjecutarOperacion("updatedesarrollador", listaUpdate, CommandType.StoredProcedure);

        }

        public static void DeleteDesarrollador(Desarrollador oDesarrollador)
        {
            List<SqlParameter> lista = new List<SqlParameter>();
            SqlParameter codigo = new SqlParameter("@id", oDesarrollador.DesarrolladorID);

            lista.Add(codigo);

            Conexion.EjecutarOperacion("deleteDesarrollador", lista, CommandType.StoredProcedure);
        }
    }
}
