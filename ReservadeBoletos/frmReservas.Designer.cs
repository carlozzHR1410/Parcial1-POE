namespace ReservadeBoletos
{
    partial class frmReservas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblCantidadBoletos = new System.Windows.Forms.Label();
            this.txtCantidadBoletos = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadBoletos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(20, 70);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(29, 13);
            this.lblDUI.TabIndex = 2;
            this.lblDUI.Text = "DUI:";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(80, 67);
            this.txtDUI.MaxLength = 10;
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(200, 20);
            this.txtDUI.TabIndex = 3;
            this.txtDUI.TextChanged += new System.EventHandler(this.txtDUI_TextChanged);
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 110);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Location = new System.Drawing.Point(20, 150);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(44, 13);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "Pelicula";
            // 
            // lblCantidadBoletos
            // 
            this.lblCantidadBoletos.AutoSize = true;
            this.lblCantidadBoletos.Location = new System.Drawing.Point(20, 190);
            this.lblCantidadBoletos.Name = "lblCantidadBoletos";
            this.lblCantidadBoletos.Size = new System.Drawing.Size(90, 13);
            this.lblCantidadBoletos.TabIndex = 6;
            this.lblCantidadBoletos.Text = "Cantidad Boletos:";
            // 
            // txtCantidadBoletos
            // 
            this.txtCantidadBoletos.Location = new System.Drawing.Point(130, 187);
            this.txtCantidadBoletos.MaxLength = 3;
            this.txtCantidadBoletos.Name = "txtCantidadBoletos";
            this.txtCantidadBoletos.Size = new System.Drawing.Size(50, 20);
            this.txtCantidadBoletos.TabIndex = 7;
            this.txtCantidadBoletos.TextChanged += new System.EventHandler(this.txtCantidadBoletos_TextChanged);
            this.txtCantidadBoletos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadBoletos_KeyPress);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(80, 107);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoria.TabIndex = 8;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(80, 147);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(200, 21);
            this.cmbPelicula.TabIndex = 9;
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(200, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colDUI,
            this.colCategoria,
            this.colPelicula,
            this.colCantidadBoletos,
            });
            this.dgvReservas.Location = new System.Drawing.Point(-5, 266);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(800, 200);
            this.dgvReservas.TabIndex = 11;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colDUI
            // 
            this.colDUI.HeaderText = "DUI";
            this.colDUI.Name = "colDUI";
            this.colDUI.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colPelicula
            // 
            this.colPelicula.HeaderText = "Película";
            this.colPelicula.Name = "colPelicula";
            this.colPelicula.ReadOnly = true;
            // 
            // colCantidadBoletos
            // 
            this.colCantidadBoletos.HeaderText = "Cantidad Boletos";
            this.colCantidadBoletos.Name = "colCantidadBoletos";
            this.colCantidadBoletos.ReadOnly = true;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbPelicula);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtCantidadBoletos);
            this.Controls.Add(this.lblCantidadBoletos);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmReservas";
            this.Text = "Crear Reservas";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblCantidadBoletos;
        private System.Windows.Forms.TextBox txtCantidadBoletos;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadBoletos;
    }
}