using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class Conexion
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-19G8BCC;database=dbBiblioteca;Trusted_Connection=True;");
        SqlDataAdapter sqlDa;

        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {

            }
        }
        public void desconectar()
        {
            con.Close();
        }

        public DataTable ejecutarSql(String consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                conectar();
                SqlCommand command = con.CreateCommand();
                command.CommandText = consulta;
                command.CommandType = CommandType.Text;
                command.Connection = con;
                sqlDa = new SqlDataAdapter(command);
                sqlDa.Fill(dt);
                desconectar();
            }
            catch (Exception ex)
            {
            }
            return dt;

        }

    }
}
