using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDI
{
    public class MiConexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=LOCALHOST;DataBase= Northwind;Integrated Security=true");
        public SqlConnection pConexion
        {
            get
            {
                return Conexion;
            }
        }
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
