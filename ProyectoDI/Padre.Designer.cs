
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
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.página1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.página2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasNoConectadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarInformesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.abrirToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.formulariosToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem,
            this.consultasNoConectadoToolStripMenuItem,
            this.relacionesToolStripMenuItem,
            this.realizarInformesToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem
            // 
            this.consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.página1ToolStripMenuItem,
            this.página2ToolStripMenuItem});
            this.consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem.Name = "consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem";
            this.consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem.Text = "Consultas conectado. Utilizando la tabla Películas";
            // 
            // página1ToolStripMenuItem
            // 
            this.página1ToolStripMenuItem.Name = "página1ToolStripMenuItem";
            this.página1ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.página1ToolStripMenuItem.Text = "Página 1";
            this.página1ToolStripMenuItem.Click += new System.EventHandler(this.página1ToolStripMenuItem_Click);
            // 
            // página2ToolStripMenuItem
            // 
            this.página2ToolStripMenuItem.Name = "página2ToolStripMenuItem";
            this.página2ToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.página2ToolStripMenuItem.Text = "Página 2";
            this.página2ToolStripMenuItem.Click += new System.EventHandler(this.página2ToolStripMenuItem_Click);
            // 
            // consultasNoConectadoToolStripMenuItem
            // 
            this.consultasNoConectadoToolStripMenuItem.Name = "consultasNoConectadoToolStripMenuItem";
            this.consultasNoConectadoToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.consultasNoConectadoToolStripMenuItem.Text = "Consultas no conectado";
            this.consultasNoConectadoToolStripMenuItem.Click += new System.EventHandler(this.consultasNoConectadoToolStripMenuItem_Click);
            // 
            // relacionesToolStripMenuItem
            // 
            this.relacionesToolStripMenuItem.Name = "relacionesToolStripMenuItem";
            this.relacionesToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.relacionesToolStripMenuItem.Text = "Relaciones";
            this.relacionesToolStripMenuItem.Click += new System.EventHandler(this.relacionesToolStripMenuItem_Click);
            // 
            // realizarInformesToolStripMenuItem
            // 
            this.realizarInformesToolStripMenuItem.Name = "realizarInformesToolStripMenuItem";
            this.realizarInformesToolStripMenuItem.Size = new System.Drawing.Size(334, 22);
            this.realizarInformesToolStripMenuItem.Text = "Realizar informes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre";
            this.Text = "ProyectoDI";
            this.Load += new System.EventHandler(this.Padre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasConectadoUtilizandoLaTablaPelículasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasNoConectadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarInformesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem página1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem página2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem milista;
    }
}

