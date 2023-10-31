using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Librerias ADO NET
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Configuration;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pjConexionClase
{
    public class LogicaNegocio
    {
        //Objeto de la clase conexion
        Conexion objCon = new Conexion();
        string mensaje;
        //Variable de la clase conexion
        //SqlConnection cn;
        SqlConnection cn = new SqlConnection();
/* =========================== METODOS PARA CONTRATISTAS ===================================*/
        public DataTable listaUnContratista()
        {
            cn = objCon.getConecta();
            SqlDataAdapter da = new SqlDataAdapter("SP_LISTADOCONTRATISTAS", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // METODO QUE RECUPERA EL ID POSTERIOR
        public string generaCodigo1()
        {
            cn = objCon.getConecta();
            cn.Open();

            SqlCommand cmd = new SqlCommand("SP_ULTIMOCONTRATISTA", cn);
            string result = cmd.ExecuteScalar()?.ToString();

            if (!string.IsNullOrEmpty(result) && result.Length == 6)
            {
                int numero;
                if (int.TryParse(result.Substring(3), out numero))
                {
                    // Aumenta el número en 1 y luego formatea nuevamente con tres dígitos.
                    string nuevoNumero = (numero + 1).ToString("000");
                    return "CON" + nuevoNumero;
                }
            }
            // En caso de cualquier error o si el formato no es el esperado, regresa un valor predeterminado.
            return "CON001";
        }
        // METODO QUE REGISTRA UN NUEVO CONTRATISTA
        public string nuevoContratista(string codigo, string nombre, string apellido_paterno, string apellido_materno, string telefono, string email)
        {
            mensaje = "";
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_NUEVOCONTRATISTA", cn);
            // Agrega los parámetros a la instrucción SQL.
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ide", SqlDbType.Char).Value = codigo;
            cmd.Parameters.Add("nom", SqlDbType.Char).Value = nombre;
            cmd.Parameters.Add("pat", SqlDbType.Char).Value = apellido_paterno;
            cmd.Parameters.Add("mat", SqlDbType.Char).Value = apellido_materno;
            cmd.Parameters.Add("fon", SqlDbType.Char).Value = telefono;
            cmd.Parameters.Add("ema", SqlDbType.Char).Value = email;
            // Ejecuta la instrucción SQL.
            int n = cmd.ExecuteNonQuery();
            // Verifica si se ejecutó correctamente la instrucción SQL.
            if (n > 0)
            {
                mensaje = "CONTRATISTA REGISTRADO CORRECTAMENTE...!";
            }
            else
            {
                mensaje = "OCURRIÓ UN ERROR AL REGISTRAR EL CONTRATISTA.";
            }
            // Cierra la conexión.
            cn.Close();
            // Devuelve el mensaje.
            return mensaje;
        }
        // METODO QUE ACTUALIZA LOS DATOS DE UN CONTRATISTA
        public string actualizaContratista(string codigo, string nombre,
            string apellido_paterno, string apellido_materno, string telefono, string email)
        {
            mensaje = "";
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_ACTUALIZACONTRATISTA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ide", SqlDbType.Char).Value = codigo;
            cmd.Parameters.Add("nom", SqlDbType.Char).Value = nombre;
            cmd.Parameters.Add("pat", SqlDbType.Char).Value = apellido_paterno;
            cmd.Parameters.Add("mat", SqlDbType.Char).Value = apellido_materno;
            cmd.Parameters.Add("fon", SqlDbType.Char).Value = telefono;
            cmd.Parameters.Add("ema", SqlDbType.Char).Value = email;

            try
            {
                int n = cmd.ExecuteNonQuery();
                mensaje = n.ToString() + "CONTRATISTA ACTUALIZADO CORRECTAMENTE...!";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }
        // METODO QUE ELIMINA LOS DATOS DE UN CONTRATISTA
        public string eliminaContratista(string codigo)
        {
            mensaje = "";
            cn = objCon.getConecta();
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCONTRATISTA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ide", SqlDbType.Char).Value = codigo;

            try
            {
                int n = cmd.ExecuteNonQuery();
                mensaje = n.ToString() + " EQUIPO ELIMINADO CORRECTAMENTE";
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }
    }
}
