
namespace CarrerasFrontend
{
    partial class Frm_Cargar_Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cargar_Materias));
            this.lbCbCarrera = new System.Windows.Forms.Label();
            this.lbAsignatura = new System.Windows.Forms.Label();
            this.cbAsignatura = new System.Windows.Forms.ComboBox();
            this.lbCuatrimestre = new System.Windows.Forms.Label();
            this.cbCuatrimestre = new System.Windows.Forms.ComboBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbAnio = new System.Windows.Forms.Label();
            this.cbAnio = new System.Windows.Forms.ComboBox();
            this.tbCarrera = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año_de_cursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pCarrera = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.pCarrera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCbCarrera
            // 
            this.lbCbCarrera.AutoSize = true;
            this.lbCbCarrera.Location = new System.Drawing.Point(24, 33);
            this.lbCbCarrera.Name = "lbCbCarrera";
            this.lbCbCarrera.Size = new System.Drawing.Size(41, 13);
            this.lbCbCarrera.TabIndex = 1000;
            this.lbCbCarrera.Text = "Carrera";
            // 
            // lbAsignatura
            // 
            this.lbAsignatura.AutoSize = true;
            this.lbAsignatura.Location = new System.Drawing.Point(20, 216);
            this.lbAsignatura.Name = "lbAsignatura";
            this.lbAsignatura.Size = new System.Drawing.Size(57, 13);
            this.lbAsignatura.TabIndex = 1001;
            this.lbAsignatura.Text = "Asignatura";
            // 
            // cbAsignatura
            // 
            this.cbAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAsignatura.FormattingEnabled = true;
            this.cbAsignatura.Location = new System.Drawing.Point(93, 213);
            this.cbAsignatura.Name = "cbAsignatura";
            this.cbAsignatura.Size = new System.Drawing.Size(154, 21);
            this.cbAsignatura.TabIndex = 1;
            this.cbAsignatura.SelectedIndexChanged += new System.EventHandler(this.cbAsignatura_SelectedIndexChanged);
            // 
            // lbCuatrimestre
            // 
            this.lbCuatrimestre.AutoSize = true;
            this.lbCuatrimestre.Location = new System.Drawing.Point(20, 279);
            this.lbCuatrimestre.Name = "lbCuatrimestre";
            this.lbCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lbCuatrimestre.TabIndex = 1002;
            this.lbCuatrimestre.Text = "Cuatrimestre";
            // 
            // cbCuatrimestre
            // 
            this.cbCuatrimestre.FormattingEnabled = true;
            this.cbCuatrimestre.Items.AddRange(new object[] {
            "Primero",
            "Segundo"});
            this.cbCuatrimestre.Location = new System.Drawing.Point(93, 276);
            this.cbCuatrimestre.Name = "cbCuatrimestre";
            this.cbCuatrimestre.Size = new System.Drawing.Size(154, 21);
            this.cbCuatrimestre.TabIndex = 2;
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAgregar.Location = new System.Drawing.Point(93, 411);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(104, 41);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Cargar Materia";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Location = new System.Drawing.Point(12, 340);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(68, 13);
            this.lbAnio.TabIndex = 1005;
            this.lbAnio.Text = "Año Cursado";
            // 
            // cbAnio
            // 
            this.cbAnio.FormattingEnabled = true;
            this.cbAnio.Items.AddRange(new object[] {
            "1er",
            "2do",
            "3ero",
            "4to",
            "5to"});
            this.cbAnio.Location = new System.Drawing.Point(93, 337);
            this.cbAnio.Name = "cbAnio";
            this.cbAnio.Size = new System.Drawing.Size(154, 21);
            this.cbAnio.TabIndex = 3;
            // 
            // tbCarrera
            // 
            this.tbCarrera.Location = new System.Drawing.Point(81, 33);
            this.tbCarrera.Name = "tbCarrera";
            this.tbCarrera.Size = new System.Drawing.Size(154, 20);
            this.tbCarrera.TabIndex = 0;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(81, 81);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(154, 20);
            this.tbTitulo.TabIndex = 1006;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(24, 84);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(33, 13);
            this.lbTitulo.TabIndex = 1007;
            this.lbTitulo.Text = "Titulo";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.Cod_Materia,
            this.Nombre,
            this.Cuatrimestre,
            this.Año_de_cursado,
            this.borrar});
            this.dgvDetalles.Location = new System.Drawing.Point(295, 12);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(592, 440);
            this.dgvDetalles.TabIndex = 5;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            // 
            // colNro
            // 
            this.colNro.HeaderText = "Cod_detalle";
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNro.Visible = false;
            this.colNro.Width = 50;
            // 
            // Cod_Materia
            // 
            this.Cod_Materia.HeaderText = "Cod_Materia";
            this.Cod_Materia.Name = "Cod_Materia";
            this.Cod_Materia.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Materia";
            this.Nombre.MinimumWidth = 125;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cuatrimestre
            // 
            this.Cuatrimestre.HeaderText = "Cuatrimestre";
            this.Cuatrimestre.Name = "Cuatrimestre";
            this.Cuatrimestre.ReadOnly = true;
            // 
            // Año_de_cursado
            // 
            this.Año_de_cursado.HeaderText = "Año de cursado";
            this.Año_de_cursado.Name = "Año_de_cursado";
            this.Año_de_cursado.ReadOnly = true;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "Acciones";
            this.borrar.Name = "borrar";
            this.borrar.ReadOnly = true;
            this.borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.borrar.Text = "Quitar";
            this.borrar.ToolTipText = "Quitar";
            this.borrar.UseColumnTextForButtonValue = true;
            // 
            // pCarrera
            // 
            this.pCarrera.BackColor = System.Drawing.Color.Silver;
            this.pCarrera.Controls.Add(this.lbTitulo);
            this.pCarrera.Controls.Add(this.tbTitulo);
            this.pCarrera.Controls.Add(this.tbCarrera);
            this.pCarrera.Controls.Add(this.lbCbCarrera);
            this.pCarrera.Location = new System.Drawing.Point(12, 12);
            this.pCarrera.Name = "pCarrera";
            this.pCarrera.Size = new System.Drawing.Size(277, 143);
            this.pCarrera.TabIndex = 1008;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(729, 476);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(158, 37);
            this.btSave.TabIndex = 1009;
            this.btSave.Text = "Guardar";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.Location = new System.Drawing.Point(620, 476);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(63, 37);
            this.btCancelar.TabIndex = 1010;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // Frm_Cargar_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 525);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbAnio);
            this.Controls.Add(this.cbAnio);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbCuatrimestre);
            this.Controls.Add(this.cbCuatrimestre);
            this.Controls.Add(this.lbAsignatura);
            this.Controls.Add(this.cbAsignatura);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.pCarrera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cargar_Materias";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Materias";
            this.Load += new System.EventHandler(this.Frm_Cargar_Materias_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Cargar_Materias_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.pCarrera.ResumeLayout(false);
            this.pCarrera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCbCarrera;
        private System.Windows.Forms.Label lbAsignatura;
        private System.Windows.Forms.Label lbCuatrimestre;
        private System.Windows.Forms.ComboBox cbCuatrimestre;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.ComboBox cbAnio;
        private System.Windows.Forms.TextBox tbCarrera;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Panel pCarrera;
        private System.Windows.Forms.ComboBox cbAsignatura;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año_de_cursado;
        private System.Windows.Forms.DataGridViewButtonColumn borrar;
    }
}