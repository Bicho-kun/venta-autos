using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//Librerias necesarias
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WS_coches
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCoches : IServiceCoches
    {
        //Establecemos la conección con la base de datos
        string dbConexion = ConfigurationManager.ConnectionStrings["bdConexion"].ConnectionString;
        public int agregarCoche(Coches coche)
        {
            //variable de tipo int que recibe las filas afectadas
            int res = 0;
            try
            {
                //Instancia de slq connection para abrir la conexion
                SqlConnection cn = new SqlConnection(dbConexion);
                //abrir conexion a BD
                cn.Open();
                //Indicamos la sentencia o comando para trabajar
                SqlCommand cm = new SqlCommand("sp_addCoche",cn);
                //indicamos el tipo de comando
                cm.CommandType = CommandType.StoredProcedure;
                //Pasamos todos los parametros del procedimiento almacenado 
                cm.Parameters.AddWithValue("@matricula",coche.Matricula);
                cm.Parameters.AddWithValue("@marca",coche.Marca);
                cm.Parameters.AddWithValue("@modelo",coche.Modelo);
                cm.Parameters.AddWithValue("@color",coche.Color);
                cm.Parameters.AddWithValue("@precio",coche.Precio);

                //indicamos cuantas filas fueron afectadas y se la pasamos al a varible res
                res = cm.ExecuteNonQuery();
                //cerramos la conección a la BD
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("No se inserto coche",ex);
            }
            return res;
        }

        public Coches buscarCoche(string matricula)
        {
            Coches coche = new Coches();
            try
            {
                //establecemos la conección
                SqlConnection cn = new SqlConnection(dbConexion);
                //abrimos la conección
                cn.Open();

                //indicamos el comando y el nombre del procedimiento almacenado
                SqlCommand cm = new SqlCommand("sp_buscarCoche",cn);
                cm.CommandType = CommandType.StoredProcedure;
                //incamos el parametro del procedimiento almacenado
                cm.Parameters.AddWithValue("@matricula",matricula);

                //instancia sql data reader
                SqlDataReader dataReader = cm.ExecuteReader();

                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        //se leen y se asignan los datos a cada propiedad del objeto coche
                        coche.Matricula = dataReader.GetString(0);
                        coche.Marca = dataReader.GetString(1);
                        coche.Modelo = dataReader.GetString(2);
                        coche.Color = dataReader.GetString(3);
                        coche.Precio = dataReader.GetDecimal(4);
                    }
                }
                //cerramos la conexion
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("No se encontro el coche",ex);
            }
            return coche;
        }

        public int editarCoche(Coches coche)
        {
            int res = 0;
            try
            {
                //instancia de la conexion
                SqlConnection cn = new SqlConnection(dbConexion);
                //se abre la conexión
                cn.Open();
                //comnado a utilizar
                SqlCommand cm = new SqlCommand("sp_editCoche",cn);
                cm.CommandType = CommandType.StoredProcedure;
                //pasamos los parametros al procedimiento almacenado
                cm.Parameters.AddWithValue("@matricula",coche.Matricula);
                cm.Parameters.AddWithValue("@marca",coche.Marca);
                cm.Parameters.AddWithValue("@modelo",coche.Modelo);
                cm.Parameters.AddWithValue("@color",coche.Color);
                cm.Parameters.AddWithValue("@precio",coche.Precio);

                //se manda a la variable res número  de filas afectadas
                res = cm.ExecuteNonQuery();

                //cerramos la conexion
                cn.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo editar",ex);
            }
            return res;
        }

        public int eliminarCoche(string matricula)
        {
            int res = 0;
            try
            {
                //instancia de la conexión
                SqlConnection cn = new SqlConnection(dbConexion);
                //abrimos la conexion
                cn.Open();
                //indicamos el comando y el tipo
                SqlCommand cm = new SqlCommand("sp_deleteCoche",cn);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@matricula",matricula);

                //asignamos el número de filas a res
                res = cm.ExecuteNonQuery();
                //cerramos la conexión
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo eliminar",ex);
            }
            //retornamos res
            return res;
        }

        public List<Coches> mostrarCoches()
        {
            //instanciacion de una lista
            List<Coches> coches = new List<Coches>();
            try
            {
                //instancia de conexion
                SqlConnection cn = new SqlConnection(dbConexion);
                //abrimos la conexion
                cn.Open();
                //indicamos comando y tipo
                SqlCommand cm = new SqlCommand("sp_showCoches",cn);
                cm.CommandType = CommandType.StoredProcedure;

                //leemos los datos
                SqlDataReader dataReader = cm.ExecuteReader();
                //comprabamos que el datareader trae registros
                if (dataReader.HasRows)
                {
                    if (dataReader.Read())
                    {
                        coches.Add(new Coches() {
                            Matricula = dataReader.GetString(0),
                            Marca = dataReader.GetString(1),
                            Modelo = dataReader.GetString(2),
                            Color = dataReader.GetString(3),
                            Precio = dataReader.GetDecimal(4)
                        });
                    }
                }
                //cerramos la conexion
                cn.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("No se encontraron registros",ex);
            }
            return coches;
        }
    }
}
