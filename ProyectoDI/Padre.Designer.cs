
namespace ProyectoDI
{
    partial class Padre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.milista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem,
            this.milista});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.form3ToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form2ToolStripMenuItem.Text = "Form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // form3ToolStripMenuItem
            // 
            this.form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            this.form3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.form3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form3ToolStripMenuItem.Text = "Form3";
            this.form3ToolStripMenuItem.Click += new System.EventHandler(this.form3ToolStripMenuItem_Click);
            // 
            // milista
            // 
            this.milista.Name = "milista";
            this.milista.Size = new System.Drawing.Size(99, 20);
            this.milista.Text = "Forms Abiertos";
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Padre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milista;
    }
}

