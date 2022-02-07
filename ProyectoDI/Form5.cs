using Microsoft.VisualBasic;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private MiConexion Conexion = new MiConexion();
        DataSet das1 = new DataSet();
        SqlDataAdapter adaporders;
        SqlDataAdapter adapdetails;
        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                String sql1 = "select * from Clientes";
                String sql2 = "select * from Facturas";
                //'Hay un solo das1 y dos adaptadores
                adaporders = new SqlDataAdapter(sql1, Conexion.pConexion);
                adaporders.Fill(das1, "padre");
                adapdetails = new SqlDataAdapter(sql2, Conexion.pConexion);
                adapdetails.Fill(das1, "hijo");

                //'Creo la relacion en el das1 
                DataColumn a, b;
                a = das1.Tables["padre"].Columns["CodCli"];
                b = das1.Tables["hijo"].Columns["CodCli"];
                das1.Relations.Add("mirelacion", a, b);
                //'visualizamos
                dataGridView1.DataSource = das1;
                dataGridView1.DataMember = "padre";
                dataGridView2.DataSource = das1;
                dataGridView2.DataMember = "padre.mirelacion";

                // Crear automaticamente la sql para update
                SqlCommandBuilder cmb1 = new SqlCommandBuilder(adaporders);
                SqlCommandBuilder cmb2 = new SqlCommandBuilder(adapdetails);

                label3.Text = Convert.ToString(das1.Tables["padre"].Rows.Count - 1) + " filas.";
                label4.Text = Convert.ToString(dataGridView2.Rows.Count - 1) + " filas.";

                das1.Tables[0].PrimaryKey = new DataColumn[] { das1.Tables[0].Columns["CodCli"] };

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = Convert.ToString(dataGridView2.Rows.Count - 1) + " filas.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aaa = 0;
            aaa = Convert.ToInt32(Interaction.InputBox("Escribe el CodCli", "Borrar por CodCli", ""));
            das1.Tables[0].Rows.Find(aaa).Delete();
        }
    }
}
