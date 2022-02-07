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
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            Conexion.CerrarConexion();
        }
    }
}
