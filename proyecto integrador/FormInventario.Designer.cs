namespace proyecto_integrador
{
    partial class FormInventario
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvLotes;
        private System.Windows.Forms.GroupBox grpStock;
        private System.Windows.Forms.Label lblLoteAjuste;
        private System.Windows.Forms.ComboBox cmbLotes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnSumarStock;
        private System.Windows.Forms.Button btnQuitarStock;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.GroupBox grpNuevoLote;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.ComboBox cmbSemillas;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.ComboBox cmbEncargados;
        private System.Windows.Forms.Label lblCodigoLote;
        private System.Windows.Forms.TextBox txtCodigoLote;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtEmpresaOrigen;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Button btnCrearLote;

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
            dgvLotes = new DataGridView();
            grpStock = new GroupBox();
            btnRefrescar = new Button();
            btnQuitarStock = new Button();
            btnSumarStock = new Button();
            numCantidad = new NumericUpDown();
            lblCantidad = new Label();
            cmbLotes = new ComboBox();
            lblLoteAjuste = new Label();
            grpNuevoLote = new GroupBox();
            btnCrearLote = new Button();
            txtUnidad = new TextBox();
            lblUnidad = new Label();
            txtEmpresaOrigen = new TextBox();
            lblEmpresa = new Label();
            txtCodigoLote = new TextBox();
            lblCodigoLote = new Label();
            cmbEncargados = new ComboBox();
            lblEncargado = new Label();
            cmbSemillas = new ComboBox();
            lblSemilla = new Label();
            Porcentajes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLotes).BeginInit();
            grpStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            grpNuevoLote.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLotes
            // 
            dgvLotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLotes.Location = new Point(20, 23);
            dgvLotes.Margin = new Padding(4, 5, 4, 5);
            dgvLotes.Name = "dgvLotes";
            dgvLotes.ReadOnly = true;
            dgvLotes.RowHeadersWidth = 51;
            dgvLotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLotes.Size = new Size(1292, 388);
            dgvLotes.TabIndex = 0;
            dgvLotes.CellContentClick += dgvLotes_CellContentClick;
            // 
            // grpStock
            // 
            grpStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpStock.Controls.Add(btnRefrescar);
            grpStock.Controls.Add(btnQuitarStock);
            grpStock.Controls.Add(btnSumarStock);
            grpStock.Controls.Add(numCantidad);
            grpStock.Controls.Add(lblCantidad);
            grpStock.Controls.Add(cmbLotes);
            grpStock.Controls.Add(lblLoteAjuste);
            grpStock.Location = new Point(20, 421);
            grpStock.Margin = new Padding(4, 5, 4, 5);
            grpStock.Name = "grpStock";
            grpStock.Padding = new Padding(4, 5, 4, 5);
            grpStock.Size = new Size(1292, 136);
            grpStock.TabIndex = 1;
            grpStock.TabStop = false;
            grpStock.Text = "Ajustar Stock de Lote";
            grpStock.Enter += grpStock_Enter;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(1060, 40);
            btnRefrescar.Margin = new Padding(4, 5, 4, 5);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(180, 43);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "Actualizar tabla";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnQuitarStock
            // 
            btnQuitarStock.Location = new Point(780, 40);
            btnQuitarStock.Margin = new Padding(4, 5, 4, 5);
            btnQuitarStock.Name = "btnQuitarStock";
            btnQuitarStock.Size = new Size(173, 43);
            btnQuitarStock.TabIndex = 4;
            btnQuitarStock.Text = "Quitar del lote";
            btnQuitarStock.UseVisualStyleBackColor = true;
            btnQuitarStock.Click += btnQuitarStock_Click;
            // 
            // btnSumarStock
            // 
            btnSumarStock.Location = new Point(593, 40);
            btnSumarStock.Margin = new Padding(4, 5, 4, 5);
            btnSumarStock.Name = "btnSumarStock";
            btnSumarStock.Size = new Size(173, 43);
            btnSumarStock.TabIndex = 3;
            btnSumarStock.Text = "Añadir al lote";
            btnSumarStock.UseVisualStyleBackColor = true;
            btnSumarStock.Click += btnSumarStock_Click;
            // 
            // numCantidad
            // 
            numCantidad.DecimalPlaces = 2;
            numCantidad.Location = new Point(420, 46);
            numCantidad.Margin = new Padding(4, 5, 4, 5);
            numCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(147, 27);
            numCantidad.TabIndex = 2;
            numCantidad.Value = new decimal(new int[] { 100, 0, 0, 131072 });
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(340, 49);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(72, 20);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad:";
            // 
            // cmbLotes
            // 
            cmbLotes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLotes.FormattingEnabled = true;
            cmbLotes.Location = new Point(80, 45);
            cmbLotes.Margin = new Padding(4, 5, 4, 5);
            cmbLotes.Name = "cmbLotes";
            cmbLotes.Size = new Size(239, 28);
            cmbLotes.TabIndex = 1;
            // 
            // lblLoteAjuste
            // 
            lblLoteAjuste.AutoSize = true;
            lblLoteAjuste.Location = new Point(20, 49);
            lblLoteAjuste.Margin = new Padding(4, 0, 4, 0);
            lblLoteAjuste.Name = "lblLoteAjuste";
            lblLoteAjuste.Size = new Size(41, 20);
            lblLoteAjuste.TabIndex = 7;
            lblLoteAjuste.Text = "Lote:";
            // 
            // grpNuevoLote
            // 
            grpNuevoLote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpNuevoLote.Controls.Add(Porcentajes);
            grpNuevoLote.Controls.Add(btnCrearLote);
            grpNuevoLote.Controls.Add(txtUnidad);
            grpNuevoLote.Controls.Add(lblUnidad);
            grpNuevoLote.Controls.Add(txtEmpresaOrigen);
            grpNuevoLote.Controls.Add(lblEmpresa);
            grpNuevoLote.Controls.Add(txtCodigoLote);
            grpNuevoLote.Controls.Add(lblCodigoLote);
            grpNuevoLote.Controls.Add(cmbEncargados);
            grpNuevoLote.Controls.Add(lblEncargado);
            grpNuevoLote.Controls.Add(cmbSemillas);
            grpNuevoLote.Controls.Add(lblSemilla);
            grpNuevoLote.Location = new Point(20, 573);
            grpNuevoLote.Margin = new Padding(4, 5, 4, 5);
            grpNuevoLote.Name = "grpNuevoLote";
            grpNuevoLote.Padding = new Padding(4, 5, 4, 5);
            grpNuevoLote.Size = new Size(1292, 177);
            grpNuevoLote.TabIndex = 2;
            grpNuevoLote.TabStop = false;
            grpNuevoLote.Text = "Registrar Nuevo Lote (usa la Cantidad de arriba como ingreso inicial)";
            // 
            // btnCrearLote
            // 
            btnCrearLote.Location = new Point(1060, 100);
            btnCrearLote.Margin = new Padding(4, 5, 4, 5);
            btnCrearLote.Name = "btnCrearLote";
            btnCrearLote.Size = new Size(180, 43);
            btnCrearLote.TabIndex = 5;
            btnCrearLote.Text = "Nuevo Lote";
            btnCrearLote.UseVisualStyleBackColor = true;
            btnCrearLote.Click += btnCrearLote_Click;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(553, 106);
            txtUnidad.Margin = new Padding(4, 5, 4, 5);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(159, 27);
            txtUnidad.TabIndex = 4;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Location = new Point(487, 111);
            lblUnidad.Margin = new Padding(4, 0, 4, 0);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(60, 20);
            lblUnidad.TabIndex = 6;
            lblUnidad.Text = "Unidad:";
            // 
            // txtEmpresaOrigen
            // 
            txtEmpresaOrigen.Location = new Point(140, 106);
            txtEmpresaOrigen.Margin = new Padding(4, 5, 4, 5);
            txtEmpresaOrigen.Name = "txtEmpresaOrigen";
            txtEmpresaOrigen.Size = new Size(319, 27);
            txtEmpresaOrigen.TabIndex = 3;
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(20, 111);
            lblEmpresa.Margin = new Padding(4, 0, 4, 0);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(118, 20);
            lblEmpresa.TabIndex = 7;
            lblEmpresa.Text = "Empresa Origen:";
            // 
            // txtCodigoLote
            // 
            txtCodigoLote.Location = new Point(927, 45);
            txtCodigoLote.Margin = new Padding(4, 5, 4, 5);
            txtCodigoLote.Name = "txtCodigoLote";
            txtCodigoLote.Size = new Size(312, 27);
            txtCodigoLote.TabIndex = 2;
            // 
            // lblCodigoLote
            // 
            lblCodigoLote.AutoSize = true;
            lblCodigoLote.Location = new Point(820, 49);
            lblCodigoLote.Margin = new Padding(4, 0, 4, 0);
            lblCodigoLote.Name = "lblCodigoLote";
            lblCodigoLote.Size = new Size(94, 20);
            lblCodigoLote.TabIndex = 8;
            lblCodigoLote.Text = "Código Lote:";
            // 
            // cmbEncargados
            // 
            cmbEncargados.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEncargados.FormattingEnabled = true;
            cmbEncargados.Location = new Point(513, 45);
            cmbEncargados.Margin = new Padding(4, 5, 4, 5);
            cmbEncargados.Name = "cmbEncargados";
            cmbEncargados.Size = new Size(279, 28);
            cmbEncargados.TabIndex = 1;
            // 
            // lblEncargado
            // 
            lblEncargado.AutoSize = true;
            lblEncargado.Location = new Point(420, 49);
            lblEncargado.Margin = new Padding(4, 0, 4, 0);
            lblEncargado.Name = "lblEncargado";
            lblEncargado.Size = new Size(83, 20);
            lblEncargado.TabIndex = 9;
            lblEncargado.Text = "Encargado:";
            // 
            // cmbSemillas
            // 
            cmbSemillas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSemillas.FormattingEnabled = true;
            cmbSemillas.Location = new Point(100, 45);
            cmbSemillas.Margin = new Padding(4, 5, 4, 5);
            cmbSemillas.Name = "cmbSemillas";
            cmbSemillas.Size = new Size(292, 28);
            cmbSemillas.TabIndex = 0;
            // 
            // lblSemilla
            // 
            lblSemilla.AutoSize = true;
            lblSemilla.Location = new Point(20, 49);
            lblSemilla.Margin = new Padding(4, 0, 4, 0);
            lblSemilla.Name = "lblSemilla";
            lblSemilla.Size = new Size(61, 20);
            lblSemilla.TabIndex = 10;
            lblSemilla.Text = "Semilla:";
            // 
            // Porcentajes
            // 
            Porcentajes.Location = new Point(780, 100);
            Porcentajes.Name = "Porcentajes";
            Porcentajes.Size = new Size(180, 43);
            Porcentajes.TabIndex = 3;
            Porcentajes.Text = "Porcentajes";
            Porcentajes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Porcentajes.UseVisualStyleBackColor = true;
            Porcentajes.Click += button1_Click;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 773);
            Controls.Add(grpNuevoLote);
            Controls.Add(grpStock);
            Controls.Add(dgvLotes);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario de Semillas - INVENTARIO";
            Load += FormInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLotes).EndInit();
            grpStock.ResumeLayout(false);
            grpStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            grpNuevoLote.ResumeLayout(false);
            grpNuevoLote.PerformLayout();
            ResumeLayout(false);
        }

        private Button Porcentajes;
    }
}