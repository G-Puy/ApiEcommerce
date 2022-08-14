using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Repositorios
{
    public class Conexion
    {
        public static string ObtenerConexion()
        {
            string CadenaConexion = "";
            //utilizando Microsoft.Extensions.Configuration; puedo agarrar la cadena de conexion
            // del appsetting.json
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            CadenaConexion = config.GetConnectionString("MiConexion");
            return CadenaConexion;
        }
        public SqlConnection CrearConexion()
        {
            return new SqlConnection(ObtenerConexion());
        }
        public bool AbrirConexion(SqlConnection cn)
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                return false;
                throw new Exception(ex.Message + "No se pudo abrir la conexion");
            }
            finally
            {
                System.Diagnostics.Debug.WriteLine("Entré al finally de abrir conexión");
            }
        }

        public bool CerrarConexion(SqlConnection cn)
        {
            try
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message + "No se pudo cerrar la conexion");
            }
            finally
            {
                cn.Dispose();
                System.Diagnostics.Debug.WriteLine("Entré al finally de cerrar conexión");
            }
        }

        public bool CerrarConexionConClose(SqlConnection cn)
        {
            try
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message + "No se pudo cerrarCLOSE la conexion");
            }
            finally
            {
                // cn.Dispose();
                System.Diagnostics.Debug.WriteLine("Entré al finally de cerrar conexión");
            }
        }



    }
}
