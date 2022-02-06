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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private string sql, sql1, sql2;
        private MiConexion Conexion = new MiConexion();
        private DataSet das1, das2;
        private SqlDataAdapter adap1, adap2, adap3, adap4;

        private void Form4_Load(object sender, EventArgs e)
        {
            sql = "select CodVend, NombVen,DirecVen,Telefono,Salario from Vendedores";
            SqlCommand cmd1 = new SqlCommand(sql, Conexion.pConexion);
            adap1 = new SqlDataAdapter(cmd1);
            das1 = new DataSet();
            adap1.Fill(das1, "aaa");
            dataGridView1.DataSource = das1.Tables[0];
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 160;

            SqlCommandBuilder cmb = new SqlCommandBuilder(adap1);

            das1.Tables[0].PrimaryKey = new DataColumn[] { das1.Tables[0].Columns["CodVend"] };

            sql1 = "Select CodCli from Clientes";
            SqlCommand cmd2 = new SqlCommand(sql1, Conexion.pConexion);
            adap2 = new SqlDataAdapter(cmd2);
            das2 = new DataSet();
            adap2.Fill(das2, "aaa");
            for (int i = 0; i < das2.Tables[0].Rows.Count - 1; i++)
            {
                comboBox1.Items.Add(das2.Tables[0].Rows[i][0]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //los XMLs se guardan en el /bin/debug
            das1.WriteXml("Vendedores.xml");
            das1.WriteXmlSchema("VendedorFormato.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //leer XML
            das1.Tables[0].Clear();
            das1.ReadXml("Vendedores.xml");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                adap1.Update(das1, "aaa");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Rows[0][1] += "x";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String direcVen = Convert.ToString(das1.Tables[0].Rows[0][1]);
            das1.Tables[0].Rows[0][1] = direcVen.Substring(0, direcVen.Length - 1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Rows.Find(textBox1.Text).Delete();
        }
    }
}
