using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI
{
    public partial class Form2 : Form
    {
        private string sql;
        private int cont;
        private MiConexion Conexion = new MiConexion();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            llenarComboGeneros();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void contarSin_Click(object sender, EventArgs e)
        {
            sql = "SELECT COUNT(*) FROM [Peliculas] WHERE CodGenero = " + tbCodGenero.Text;
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            labelResultadoContar.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }

        private void contarCon_Click(object sender, EventArgs e)
        {
            sql = "SELECT COUNT(*) FROM [Peliculas] WHERE CodGenero = @genero";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            cmd.Parameters.Add("@genero", SqlDbType.Int).Value = tbCodGenero.Text;
            Conexion.AbrirConexion();
            labelResultadoContar.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }

        private void insertarSin_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO [Peliculas] WHERE CodGenero = " + tbCodGenero.Text;
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            labelResultadoContar.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }

        private void llenarComboGeneros()
        {
            sql = "SELECT NomGenero FROM [Generos]";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            labelResultadoContar.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }
    }
}
