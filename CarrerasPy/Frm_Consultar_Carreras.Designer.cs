
namespace CarrerasPy
{
    partial class Frm_Consultar_Carreras
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
            this.gbfiltros = new System.Windows.Forms.GroupBox();
            this.gbGridConsulta = new System.Windows.Forms.GroupBox();
            this.btnSalirConsulta = new System.Windows.Forms.Button();
            this.lblCarreraConsulta = new System.Windows.Forms.Label();
            this.cbFiltroConsulta = new System.Windows.Forms.ComboBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.Cod_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año_de_cursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbfiltros.SuspendLayout();
            this.gbGridConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // gbfiltros
            // 
            this.gbfiltros.Controls.Add(this.btnConsulta);
            this.gbfiltros.Controls.Add(this.cbFiltroConsulta);
            this.gbfiltros.Controls.Add(this.lblCarreraConsulta);
            this.gbfiltros.Location = new System.Drawing.Point(12, 12);
            this.gbfiltros.Name = "gbfiltros";
            this.gbfiltros.Size = new System.Drawing.Size(620, 90);
            this.gbfiltros.TabIndex = 0;
            this.gbfiltros.TabStop = false;
            this.gbfiltros.Text = "Criterios de búsqueda";
            // 
            // gbGridConsulta
            // 
            this.gbGridConsulta.Controls.Add(this.dgvDetalles);
            this.gbGridConsulta.Location = new System.Drawing.Point(12, 108);
            this.gbGridConsulta.Name = "gbGridConsulta";
            this.gbGridConsulta.Size = new System.Drawing.Size(620, 146);
            this.gbGridConsulta.TabIndex = 1;
            this.gbGridConsulta.TabStop = false;
            this.gbGridConsulta.Text = "Resultados";
            // 
            // btnSalirConsulta
            // 
            this.btnSalirConsulta.Location = new System.Drawing.Point(390, 260);
            this.btnSalirConsulta.Name = "btnSalirConsulta";
            this.btnSalirConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnSalirConsulta.TabIndex = 2;
            this.btnSalirConsulta.Text = "S&alir";
            this.btnSalirConsulta.UseVisualStyleBackColor = true;
            // 
            // lblCarreraConsulta
            // 
            this.lblCarreraConsulta.AutoSize = true;
            this.lblCarreraConsulta.Location = new System.Drawing.Point(6, 38);
            this.lblCarreraConsulta.Name = "lblCarreraConsulta";
            this.lblCarreraConsulta.Size = new System.Drawing.Size(44, 13);
            this.lblCarreraConsulta.TabIndex = 0;
            this.lblCarreraConsulta.Text = "Carrera:";
            // 
            // cbFiltroConsulta
            // 
            this.cbFiltroConsulta.FormattingEnabled = true;
            this.cbFiltroConsulta.Location = new System.Drawing.Point(56, 38);
            this.cbFiltroConsulta.Name = "cbFiltroConsulta";
            this.cbFiltroConsulta.Size = new System.Drawing.Size(121, 21);
            this.cbFiltroConsulta.TabIndex = 1;
            this.cbFiltroConsulta.SelectedIndexChanged += new System.EventHandler(this.cbFiltroConsulta_SelectedIndexChanged);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(206, 36);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Materia,
            this.Nombre,
            this.Cuatrimestre,
            this.Año_de_cursado});
            this.dgvDetalles.Location = new System.Drawing.Point(6, 19);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(447, 121);
            this.dgvDetalles.TabIndex = 6;
            // 
            // Cod_Materia
            // 
            this.Cod_Materia.HeaderText = "Cod_Materia";
            this.Cod_Materia.Name = "Cod_Materia";
            this.Cod_Materia.Visible = false;
            this.Cod_Materia.Width = 30;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Materia";
            this.Nombre.MinimumWidth = 125;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            // 
            // Año_de_cursado
            // 
            this.Año_de_cursado.HeaderText = "Año de cursado";
            this.Año_de_cursado.Name = "Año_de_cursado";
            // 
            // Frm_Consultar_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 295);
            this.Controls.Add(this.btnSalirConsulta);
            this.Controls.Add(this.gbGridConsulta);
            this.Controls.Add(this.gbfiltros);
            this.Name = "Frm_Consultar_Carreras";
            this.Text = "Frm_Consultar_Carreras";
            this.Load += new System.EventHandler(this.Frm_Consultar_Carreras_Load);
            this.gbfiltros.ResumeLayout(false);
            this.gbfiltros.PerformLayout();
            this.gbGridConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfiltros;
        private System.Windows.Forms.GroupBox gbGridConsulta;
        private System.Windows.Forms.Button btnSalirConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ComboBox cbFiltroConsulta;
        private System.Windows.Forms.Label lblCarreraConsulta;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año_de_cursado;
    }
}