using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            String filejson = File.ReadAllText(@"JSON/stocks.json");
            //Coge todo lo que hay en el string como texto plano, ignorando caracteres escape y otros simbolos
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(filejson, typeof(DataTable));
            dataGridView1.DataSource = dt;
        }
    }
}
