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
        private Form4 f4 = new Form4();
        private Form5 f5 = new Form5();
        private Form6 f6 = new Form6();
        private Form8 f8 = new Form8();

        private void Padre_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.menuStrip1.MdiWindowListItem = milista;
            f1.MdiParent = this;
            f2.MdiParent = this;
            f3.MdiParent = this;
            f4.MdiParent = this;
            f5.MdiParent = this;
            f6.MdiParent = this;
            f8.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f2.WindowState = FormWindowState.Maximized;
            f3.WindowState = FormWindowState.Maximized;
            f4.WindowState = FormWindowState.Maximized;
            f5.WindowState = FormWindowState.Maximized;
            f6.WindowState = FormWindowState.Maximized;
            f8.WindowState = FormWindowState.Maximized;
            f1.Show();
            f1.Activate();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void página1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.Activate();
        }

        private void página2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.Activate();
        }

        private void consultasNoConectadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
            f4.Activate();
        }

        private void relacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();
            f5.Activate();
        }

        private void realizarInformesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.Show();
            f6.Activate();
        }

        private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8.Show();
            f8.Activate();
        }
    }
}
