using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTesoreria.Clases
{
    public class Tesoreria
    {
        public int Id { get; set; }
        public string AhorrarOSacar { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal TotalCantidad { get; set; }
        public DateTime FechaAhorrado { get; set; }
        public DateTime FechaModificado { get; set; }
        public string Concepto { get; set; }
        public int Usuario { get; set; }
        //----------------------------Ofrenda Matutina----------------------------//
        public string GuardarOfrendaMatutina()
        {
            string respuesta = "Ok";
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spGuardarOfrendaMatutina", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);
            command.Parameters.AddWithValue("@Cantidad", Cantidad);
            command.Parameters.AddWithValue("@FechaAhorrado", FechaAhorrado);
            command.Parameters.AddWithValue("@FechaModificado", FechaModificado);
            command.Parameters.AddWithValue("@Concepto", Concepto);
            command.Parameters.AddWithValue("@QuienCapturo", Usuario);
            try
            {
                conx.Open();
                command.ExecuteNonQuery();
                conx.Close();
            }
            catch(Exception error)
            {
                respuesta = "Ha ocurrido un error: " + error.Message;
                if (conx.State == ConnectionState.Open)
                {
                    conx.Close();
                }
            }
            return respuesta;
        }
        static public DataTable DataMatutino(string concepto)
        {
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spDataMatutino", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            conx.Open();
            da.Fill(t);
            conx.Close();
            return t;
        }
        static public int SiguienteMatutina(string concepto)
        {
            int siguienteMatutina;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spSiguienteMatutina", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            siguienteMatutina = int.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return siguienteMatutina;
        }
        static public decimal TotalesMatutino(string concepto)
        {
            decimal totales;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spTotalesMatutino", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            totales = decimal.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return totales;
        }
        static public decimal TabTotalMatutina(string concepto)
        {
            decimal totales;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spTabTotalMatutina", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            totales = decimal.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return totales;
        }
        //-------------------------------Termina Ofrenda Matutina------------------------------//

        //-------------------------------Diezmo------------------------------------------------//
        public string GuardarDiezmo()
        {
            string respuesta = "Ok";
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spGuardarDiezmo", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);
            command.Parameters.AddWithValue("@Cantidad", Cantidad);
            command.Parameters.AddWithValue("@FechaAhorrado", FechaAhorrado);
            command.Parameters.AddWithValue("@FechaModificado", FechaModificado);
            command.Parameters.AddWithValue("@Concepto", Concepto);
            command.Parameters.AddWithValue("@QuienCapturo", Usuario);
            try
            {
                conx.Open();
                command.ExecuteNonQuery();
                conx.Close();
            }
            catch (Exception error)
            {
                respuesta = "Ha ocurrido un error: " + error.Message;
                if (conx.State == ConnectionState.Open)
                {
                    conx.Close();
                }
            }
            return respuesta;
        }
        static public DataTable DataDiezmo(string concepto)
        {
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spDataDiezmo", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            conx.Open();
            da.Fill(t);
            conx.Close();
            return t;
        }
        static public int SiguienteDiezmo(string concepto)
        {
            int siguienteMatutina;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spSiguienteDiezmo", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            siguienteMatutina = int.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return siguienteMatutina;
        }
        static public decimal TotalesDiezmo(string concepto)
        {
            decimal totales;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spTotalesDiezmo", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            totales = decimal.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return totales;
        }
        static public decimal TabTotalDiezmo(string concepto)
        {
            decimal totales;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spTabTotalDiezmo", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            totales = decimal.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return totales;
        }
        //-------------------------------Termina Diezmo----------------------------------------//

        //-------------------------------Ofrenda Vespertina------------------------------------------------//
        public string GuardarOfrendaVespertina()
        {
            string respuesta = "Ok";
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spGuardarOfrendaVespertina", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Descripcion", Descripcion);
            command.Parameters.AddWithValue("@Cantidad", Cantidad);
            command.Parameters.AddWithValue("@FechaAhorrado", FechaAhorrado);
            command.Parameters.AddWithValue("@FechaModificado", FechaModificado);
            command.Parameters.AddWithValue("@Concepto", Concepto);
            command.Parameters.AddWithValue("@QuienCapturo", Usuario);
            try
            {
                conx.Open();
                command.ExecuteNonQuery();
                conx.Close();
            }
            catch (Exception error)
            {
                respuesta = "Ha ocurrido un error: " + error.Message;
                if (conx.State == ConnectionState.Open)
                {
                    conx.Close();
                }
            }
            return respuesta;
        }
        static public DataTable DataVespertino(string concepto)
        {
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spDataVespertino", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            conx.Open();
            da.Fill(t);
            conx.Close();
            return t;
        }
        static public int SiguienteVespertina(string concepto)
        {
            int siguienteMatutina;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spSiguienteVespertina", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            siguienteMatutina = int.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return siguienteMatutina;
        }
        static public decimal TotalesVespertina(string concepto)
        {
            decimal totales;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spTotalesVespertino", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            totales = decimal.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return totales;
        }
        static public decimal TabTotalVespertina(string concepto)
        {
            decimal totales;
            SqlConnection conx = Clases.Conexion.Conectar();
            SqlCommand command = new SqlCommand("spTabTotalVespertina", conx);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Concepto", concepto);
            conx.Open();
            totales = decimal.Parse(command.ExecuteScalar().ToString());
            conx.Close();
            return totales;
        }
        //-------------------------------Termina Vespertina----------------------------------------//
    }
}
