
namespace CarrerasFrontend
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gunaPpal = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.transacciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msPpal";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMateriasToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // consultarMateriasToolStripMenuItem
            // 
            this.consultarMateriasToolStripMenuItem.Name = "consultarMateriasToolStripMenuItem";
            this.consultarMateriasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.consultarMateriasToolStripMenuItem.Text = "Consultar Carreras";
            // 
            // transacciónToolStripMenuItem
            // 
            this.transacciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarMateriasToolStripMenuItem,
            this.consultaCarrerasToolStripMenuItem});
            this.transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            this.transacciónToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.transacciónToolStripMenuItem.Text = "Carreras";
            // 
            // cargarMateriasToolStripMenuItem
            // 
            this.cargarMateriasToolStripMenuItem.Name = "cargarMateriasToolStripMenuItem";
            this.cargarMateriasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cargarMateriasToolStripMenuItem.Text = "Cargar materias";
            this.cargarMateriasToolStripMenuItem.Click += new System.EventHandler(this.cargarMateriasToolStripMenuItem_Click);
            // 
            // consultaCarrerasToolStripMenuItem
            // 
            this.consultaCarrerasToolStripMenuItem.Name = "consultaCarrerasToolStripMenuItem";
            this.consultaCarrerasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultaCarrerasToolStripMenuItem.Text = "Consulta carreras";
            this.consultaCarrerasToolStripMenuItem.Click += new System.EventHandler(this.consultaCarrerasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReporteToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // verReporteToolStripMenuItem
            // 
            this.verReporteToolStripMenuItem.Name = "verReporteToolStripMenuItem";
            this.verReporteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.verReporteToolStripMenuItem.Text = "Ver reporte";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de..";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gunaPpal
            // 
            this.gunaPpal.BorderRadius = 30;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2ShadowForm gunaPpal;
    }
}

