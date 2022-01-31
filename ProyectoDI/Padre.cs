using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI
{
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
        }
        public static Form1 f1 = new Form1();

        private Form2 f2 = new Form2();
        private Form3 f3 = new Form3();

        private void Padre_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.menuStrip1.MdiWindowListItem = milista;
            f1.MdiParent = this;
            f2.MdiParent = this;
            f3.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f2.WindowState = FormWindowState.Maximized;
            f3.WindowState = FormWindowState.Maximized;
            f1.Show();
            f1.Activate();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.Activate();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.Activate();
        }
    }
}
