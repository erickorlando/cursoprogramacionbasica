namespace SistemaPrestamos
{
    partial class FrmClientes
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label distritoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.distritoTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.btnGrabarTodo = new System.Windows.Forms.Button();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            distritoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(753, 14);
            this.btnNuevo.TabIndex = 8;
            // 
            // lblContador
            // 
            this.lblContador.Location = new System.Drawing.Point(18, 525);
            this.lblContador.Size = new System.Drawing.Size(202, 19);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(753, 110);
            this.btnRegistrar.TabIndex = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(753, 62);
            this.btnEditar.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(753, 158);
            this.btnEliminar.TabIndex = 11;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(18, 67);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(139, 19);
            fechaNacimientoLabel.TabIndex = 2;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // distritoLabel
            // 
            distritoLabel.AutoSize = true;
            distritoLabel.Location = new System.Drawing.Point(18, 97);
            distritoLabel.Name = "distritoLabel";
            distritoLabel.Size = new System.Drawing.Size(66, 19);
            distritoLabel.TabIndex = 4;
            distritoLabel.Text = "Distrito:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(18, 138);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(63, 19);
            correoLabel.TabIndex = 6;
            correoLabel.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tu nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(179, 19);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // bsCliente
            // 
            this.bsCliente.DataSource = typeof(SistemaPrestamos.Cliente);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.salarioBrutoDataGridViewTextBoxColumn,
            this.FechaNacimiento,
            this.Distrito,
            this.Correo});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 290);
            this.dataGridView1.TabIndex = 12;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 91;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 69;
            // 
            // salarioBrutoDataGridViewTextBoxColumn
            // 
            this.salarioBrutoDataGridViewTextBoxColumn.DataPropertyName = "SalarioBruto";
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            this.salarioBrutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.salarioBrutoDataGridViewTextBoxColumn.HeaderText = "SalarioBruto";
            this.salarioBrutoDataGridViewTextBoxColumn.Name = "salarioBrutoDataGridViewTextBoxColumn";
            this.salarioBrutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioBrutoDataGridViewTextBoxColumn.Width = 120;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle4.Format = "dd-MMMM-yy";
            this.FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            this.FechaNacimiento.Width = 153;
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            this.Distrito.ReadOnly = true;
            this.Distrito.Width = 85;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 82;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(SistemaPrestamos.ListaClientes);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCliente, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(179, 61);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(372, 27);
            this.fechaNacimientoDateTimePicker.TabIndex = 3;
            // 
            // distritoTextBox
            // 
            this.distritoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Distrito", true));
            this.distritoTextBox.Location = new System.Drawing.Point(179, 94);
            this.distritoTextBox.Name = "distritoTextBox";
            this.distritoTextBox.Size = new System.Drawing.Size(195, 27);
            this.distritoTextBox.TabIndex = 5;
            // 
            // correoTextBox
            // 
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Correo", true));
            this.correoTextBox.Location = new System.Drawing.Point(179, 135);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(256, 27);
            this.correoTextBox.TabIndex = 7;
            // 
            // btnGrabarTodo
            // 
            this.btnGrabarTodo.Location = new System.Drawing.Point(475, 127);
            this.btnGrabarTodo.Name = "btnGrabarTodo";
            this.btnGrabarTodo.Size = new System.Drawing.Size(167, 34);
            this.btnGrabarTodo.TabIndex = 13;
            this.btnGrabarTodo.Text = "&Grabar Todo";
            this.btnGrabarTodo.UseVisualStyleBackColor = true;
            this.btnGrabarTodo.Click += new System.EventHandler(this.BtnGrabarTodo_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 553);
            this.Controls.Add(this.btnGrabarTodo);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(distritoLabel);
            this.Controls.Add(this.distritoTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmClientes";
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.fechaNacimientoDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaNacimientoLabel, 0);
            this.Controls.SetChildIndex(this.distritoTextBox, 0);
            this.Controls.SetChildIndex(distritoLabel, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.lblContador, 0);
            this.Controls.SetChildIndex(this.correoTextBox, 0);
            this.Controls.SetChildIndex(correoLabel, 0);
            this.Controls.SetChildIndex(this.btnGrabarTodo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox distritoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Button btnGrabarTodo;
    }
}

