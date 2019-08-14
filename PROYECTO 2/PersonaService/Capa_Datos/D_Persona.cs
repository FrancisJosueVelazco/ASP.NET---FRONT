using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;

namespace Capa_Datos
{
    public class D_Persona
    {
        public static List<E_Persona> ListarPersona()
        {
            List<E_Persona> lstPersona = new List<E_Persona>();
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_Obtener";
                

                using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        E_Persona p = new E_Persona();
                        p.codigo = Convert.ToInt32(lector["codigo"]);
                        p.nombres = lector["nombres"] as string ?? "";
                        p.apellidos = lector["apellidos"] as string ?? "";
                        p.edad = Convert.ToInt32(lector["edad"]);
                        p.fecha = Convert.ToDateTime(lector["fecha"]);

                        lstPersona.Add(p);
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return lstPersona;
        }

        public static E_Persona listarxId(int id)
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            E_Persona p = new E_Persona();
            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarporID";
                cmd.Parameters.AddWithValue("@codigo", id);

                using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    
                    lector.Read();
                    p.codigo = Convert.ToInt32(lector["codigo"]);
                    p.nombres = lector["nombres"].ToString();
                    p.apellidos = lector["apellidos"].ToString();
                    p.edad = Convert.ToInt32(lector["edad" +
                        ""].ToString());
                    p.fecha = Convert.ToDateTime(lector["fecha"]);
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return p;
        }

        public static E_Respuesta RegistrarPersona(E_Persona request)
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            E_Respuesta response = new E_Respuesta();
            try
            {
                //dar permisos al comando de ejecucion
                cmd.Connection = c.cadena;
                //abrir conexion
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_Registrar";
                cmd.Parameters.AddWithValue("@nombres", request.nombres);
                cmd.Parameters.AddWithValue("@apellidos", request.apellidos);
                cmd.Parameters.AddWithValue("@edad", request.edad);
                cmd.Parameters.AddWithValue("@fecha", request.fecha);

                using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        response.id = Convert.ToInt32(lector["id"]);
                        response.mensaje = lector["mensaje"] as string ?? "";
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }

            return response;
        }

        public static E_Respuesta ActualizarPersona(E_Persona p)
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            E_Respuesta response = new E_Respuesta();

            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_UpdatePersona";
                cmd.Parameters.AddWithValue("@codigo", p.codigo);
                cmd.Parameters.AddWithValue("@nombres", p.nombres);
                cmd.Parameters.AddWithValue("@apellidos", p.apellidos);
                cmd.Parameters.AddWithValue("@edad", p.edad);
                cmd.Parameters.AddWithValue("@fecha", p.fecha);


                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        response.id = Convert.ToInt32(lector["id"]);
                        response.mensaje = lector["mensaje"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return response;
        }

        public static E_Respuesta EliminarPersona(int id)
        {
            Conexion c = new Conexion();
            SqlCommand cmd = new SqlCommand();
            E_Respuesta response = new E_Respuesta();
            try
            {
                cmd.Connection = c.cadena;
                cmd.Connection.Open();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_DeletePersona";
                cmd.Parameters.AddWithValue("@codigo", id);
                   
                using(SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        response.id = Convert.ToInt32(lector["id"]);
                        response.mensaje = lector["mensaje"].ToString();
                    }
                }
        
            }
            catch (Exception e)
            {
                e.ToString();
            }
            finally
            {
                cmd.Dispose();
                c.cadena.Close();
            }
            return response;
        }
        

    }
}
