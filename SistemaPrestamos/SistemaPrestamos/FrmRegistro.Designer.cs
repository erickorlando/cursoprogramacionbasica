namespace SistemaPrestamos
{
    partial class FrmRegistro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.distritoTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            distritoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(18, 129);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(139, 19);
            fechaNacimientoLabel.TabIndex = 9;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // distritoLabel
            // 
            distritoLabel.AutoSize = true;
            distritoLabel.Location = new System.Drawing.Point(18, 159);
            distritoLabel.Name = "distritoLabel";
            distritoLabel.Size = new System.Drawing.Size(66, 19);
            distritoLabel.TabIndex = 11;
            distritoLabel.Text = "Distrito:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa tu edad:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(177, 19);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(372, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Edad", true));
            this.txtEdad.Location = new System.Drawing.Point(177, 54);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(93, 27);
            this.txtEdad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Salario bruto:";
            // 
            // txtSueldo
            // 
            this.txtSueldo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "SalarioBruto", true));
            this.txtSueldo.Location = new System.Drawing.Point(177, 89);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.MaxLength = 677;
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(195, 27);
            this.txtSueldo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.salarioBrutoDataGridViewTextBoxColumn,
            this.FechaNacimiento,
            this.Distrito});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 261);
            this.dataGridView1.TabIndex = 7;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle2.Format = "dd-MMMM-yy";
            this.FechaNacimiento.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Distrito
            // 
            this.Distrito.DataPropertyName = "Distrito";
            this.Distrito.HeaderText = "Distrito";
            this.Distrito.Name = "Distrito";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(672, 53);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 28);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(18, 485);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(202, 19);
            this.lblContador.TabIndex = 6;
            this.lblContador.Text = "La cantidad de registros es ";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCliente, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(177, 123);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(372, 27);
            this.fechaNacimientoDateTimePicker.TabIndex = 3;
            // 
            // distritoTextBox
            // 
            this.distritoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Distrito", true));
            this.distritoTextBox.Location = new System.Drawing.Point(177, 156);
            this.distritoTextBox.Name = "distritoTextBox";
            this.distritoTextBox.Size = new System.Drawing.Size(195, 27);
            this.distritoTextBox.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(672, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(163, 28);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // bsCliente
            // 
            this.bsCliente.DataSource = typeof(SistemaPrestamos.Cliente);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // salarioBrutoDataGridViewTextBoxColumn
            // 
            this.salarioBrutoDataGridViewTextBoxColumn.DataPropertyName = "SalarioBruto";
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.salarioBrutoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.salarioBrutoDataGridViewTextBoxColumn.HeaderText = "SalarioBruto";
            this.salarioBrutoDataGridViewTextBoxColumn.Name = "salarioBrutoDataGridViewTextBoxColumn";
            this.salarioBrutoDataGridViewTextBoxColumn.Width = 200;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(SistemaPrestamos.Cliente);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 524);
            this.Controls.Add(distritoLabel);
            this.Controls.Add(this.distritoTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox distritoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distrito;
        private System.Windows.Forms.Button btnNuevo;
    }
}

