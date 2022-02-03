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
    public partial class Form3 : Form
    {
        private string sql;
        private MiConexion Conexion = new MiConexion();
        public Form3()
        {
            InitializeComponent();

            sql = "SELECT Fecha FROM Facturas";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet das = new DataSet();
            adap.Fill(das, "bbb");
            for (int a = 0; a < das.Tables[0].Rows.Count - 1; a++)
            {
                comboBox1.Items.Add(das.Tables[0].Rows[a][0]);
                comboBox2.Items.Add(das.Tables[0].Rows[a][0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Items[comboBox1.SelectedIndex].ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox2.Items[comboBox2.SelectedIndex].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "Select CodFac, fecha as 'Fecha', CodCli as 'Código Cliente' from facturas where fecha >= '" + comboBox1.Text + "' and fecha <='" + comboBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();

                listView1.Clear();
                listView1.GridLines = true;
                listView1.View = View.Details;
                // añadimos columnas al listview1
                listView1.Columns.Add("Código Factura", 120, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(1), 120, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(2), 120, HorizontalAlignment.Right);

                while (dr.Read())
                {
                    //tener en cuenta el numero de columnas 
                    ListViewItem fila = new ListViewItem(Convert.ToString(dr.GetValue(0)));
                    fila.SubItems.Add(Convert.ToString(dr.GetDateTime(1).ToShortDateString()));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(2)));
                    listView1.Items.Add(fila);
                }
                Conexion.CerrarConexion();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
