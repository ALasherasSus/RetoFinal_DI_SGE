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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            if (!Convert.IsDBNull(this.dataGridView1.CurrentRow.Cells[4].Value))
            {
                textBox3.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            }
            else
            {
                textBox3.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Rows.Find(textBox1.Text).Delete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int fila = Convert.ToInt32(this.textBox4.Text);
            fila = fila - 1;
            if (fila >= 0 && fila < das1.Tables[0].Rows.Count)
            {
                this.dataGridView1.Rows[fila].Selected = true;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[fila].Cells[0];
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String nombre;
            String fila;
            // Agregar "using Microsoft.VisualBasic;"
            nombre = Interaction.InputBox("Introduce el nombre del vendedor:", "ProyectoDI", "");
            for (int i = 0; i <= das1.Tables[0].Rows.Count - 1; i++)
            {
                fila = Convert.ToString(das1.Tables[0].Rows[i][1]);
                if (fila.StartsWith(nombre))
                {
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1[0, i];
                    MessageBox.Show("Encontrado");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet das3 = new DataSet();
            sql = "Select distinct CodCli from Facturas where CodCli >=" + comboBox1.Text + "order by CodCli";
            SqlCommand cmd3 = new SqlCommand(sql, Conexion.pConexion);
            adap3 = new SqlDataAdapter(cmd3);
            adap3.Fill(das3, "ccc");
            string acum = null;
            int cont = 0;
            for (int i = 0; i < das3.Tables[0].Rows.Count; i++)
            {
                acum += das3.Tables[0].Rows[i][0].ToString() + " - " + calcular(Convert.ToInt32(das3.Tables[0].Rows[i][0])).ToString() + Environment.NewLine;
                cont++;
                if (cont == 10)
                {
                    break;
                }
            }
            MessageBox.Show(acum);
        }

        private double calcular(int a)
        {
            DataSet das4 = new DataSet();
            double total = 0;
            double aa, bb;
            String id = a.ToString();
            sql2 = "Select * from Facturas where CodCli=" + id;
            SqlCommand cmd4 = new SqlCommand(sql2, Conexion.pConexion);
            adap4 = new SqlDataAdapter(cmd4);
            adap4.Fill(das4, "ddd");
            for (int i = 0; i < das4.Tables[0].Rows.Count; i++)
            {
                aa = Convert.ToDouble(das4.Tables[0].Rows[i]["Importe"]);
                bb = Convert.ToDouble(das4.Tables[0].Rows[i]["GastoEnvio"]);
                total += aa + bb;
            }
            return total;
        }
    }
}
