using Microsoft.Reporting.WinForms;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private MiConexion Conexion = new MiConexion();
        private String sql;

        private void Form6_Load(object sender, EventArgs e)
        {
            //Agregar en el proyecto primero el Conjunto de datos (meter la BD que es y arrastrar la tabla) y luego el Asistente para informes
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
            this.PeliculasTableAdapter.Fill(this.DataSet1.Peliculas);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion.AbrirConexion();
            sql = "Select * from peliculas where pais ='" + textBox1.Text.ToUpper() + "'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            SqlDataAdapter adap1 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap1.Fill(dt);
            ReportDataSource rds = new ReportDataSource("Report1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            Conexion.CerrarConexion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            Conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaccion;

            //Inicia la transaccion
            transaccion = Conexion.pConexion.BeginTransaction();
            cmd.Connection = Conexion.pConexion;
            cmd.Transaction = transaccion;

            try
            {
                cmd.CommandText = "select Precio from Peliculas where CodPelicula = 113";
                resultado = Convert.ToDouble(cmd.ExecuteScalar());
                MessageBox.Show(resultado.ToString(), "inicial");

                cmd.CommandText = "update Peliculas set Precio = Precio + 5  where CodPelicula = 113";
                cmd.ExecuteNonQuery();


                cmd.CommandText = "update Productos set UnitPrice = UnitPrice + 7.99  where ProductID = 4"; // Aquí falla!
                cmd.ExecuteNonQuery();

                transaccion.Commit();

            }
            catch (Exception)
            {
                transaccion.Rollback(); // Con esto vuelve hacia atras 

                MessageBox.Show("Se ha producido un error");    // Si ocurre un error

                cmd.CommandText = "select Precio from Peliculas where CodPelicula = 113";
                resultado = Convert.ToDouble(cmd.ExecuteScalar());

                MessageBox.Show(resultado.ToString(), "¿Es igual?");
            }
        }
    }
}
