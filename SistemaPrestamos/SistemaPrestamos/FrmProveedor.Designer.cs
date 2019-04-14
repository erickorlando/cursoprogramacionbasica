namespace SistemaPrestamos
{
    partial class FrmProveedor
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label esInternacionalLabel;
            System.Windows.Forms.Label distritoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.esInternacionalCheckBox = new System.Windows.Forms.CheckBox();
            this.listaProveedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bslistaProveedor = new System.Windows.Forms.BindingSource(this.components);
            this.distritoTextBox = new System.Windows.Forms.TextBox();
            this.btnGrabarTodo = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            esInternacionalLabel = new System.Windows.Forms.Label();
            distritoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bslistaProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(611, 9);
            this.btnNuevo.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.Location = new System.Drawing.Point(9, 525);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(611, 91);
            this.btnRegistrar.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(610, 51);
            this.btnEditar.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(610, 133);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(11, 23);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(63, 16);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(10, 58);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(131, 16);
            fechaNacimientoLabel.TabIndex = 2;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // esInternacionalLabel
            // 
            esInternacionalLabel.AutoSize = true;
            esInternacionalLabel.Location = new System.Drawing.Point(9, 88);
            esInternacionalLabel.Name = "esInternacionalLabel";
            esInternacionalLabel.Size = new System.Drawing.Size(120, 16);
            esInternacionalLabel.TabIndex = 4;
            esInternacionalLabel.Text = "Es Internacional:";
            // 
            // distritoLabel
            // 
            distritoLabel.AutoSize = true;
            distritoLabel.Location = new System.Drawing.Point(9, 116);
            distritoLabel.Name = "distritoLabel";
            distritoLabel.Size = new System.Drawing.Size(61, 16);
            distritoLabel.TabIndex = 12;
            distritoLabel.Text = "Distrito:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(141, 20);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(268, 23);
            this.nombreTextBox.TabIndex = 0;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(SistemaPrestamos.Proveedor);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.proveedorBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(141, 54);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(268, 23);
            this.fechaNacimientoDateTimePicker.TabIndex = 1;
            // 
            // esInternacionalCheckBox
            // 
            this.esInternacionalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.proveedorBindingSource, "EsInternacional", true));
            this.esInternacionalCheckBox.Location = new System.Drawing.Point(141, 83);
            this.esInternacionalCheckBox.Name = "esInternacionalCheckBox";
            this.esInternacionalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.esInternacionalCheckBox.TabIndex = 2;
            this.esInternacionalCheckBox.UseVisualStyleBackColor = true;
            // 
            // listaProveedorDataGridView
            // 
            this.listaProveedorDataGridView.AllowUserToAddRows = false;
            this.listaProveedorDataGridView.AllowUserToDeleteRows = false;
            this.listaProveedorDataGridView.AutoGenerateColumns = false;
            this.listaProveedorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaProveedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.listaProveedorDataGridView.DataSource = this.bslistaProveedor;
            this.listaProveedorDataGridView.Location = new System.Drawing.Point(12, 174);
            this.listaProveedorDataGridView.Name = "listaProveedorDataGridView";
            this.listaProveedorDataGridView.ReadOnly = true;
            this.listaProveedorDataGridView.Size = new System.Drawing.Size(808, 325);
            this.listaProveedorDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SalarioBruto";
            dataGridViewCellStyle2.Format = "C2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "SalarioBruto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 112;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Distrito";
            this.dataGridViewTextBoxColumn5.HeaderText = "Distrito";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EsInternacional";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EsInternacional";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 115;
            // 
            // bslistaProveedor
            // 
            this.bslistaProveedor.DataSource = typeof(SistemaPrestamos.ListaProveedor);
            // 
            // distritoTextBox
            // 
            this.distritoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Distrito", true));
            this.distritoTextBox.Location = new System.Drawing.Point(141, 113);
            this.distritoTextBox.Name = "distritoTextBox";
            this.distritoTextBox.Size = new System.Drawing.Size(268, 23);
            this.distritoTextBox.TabIndex = 3;
            // 
            // btnGrabarTodo
            // 
            this.btnGrabarTodo.Location = new System.Drawing.Point(441, 112);
            this.btnGrabarTodo.Name = "btnGrabarTodo";
            this.btnGrabarTodo.Size = new System.Drawing.Size(121, 23);
            this.btnGrabarTodo.TabIndex = 13;
            this.btnGrabarTodo.Text = "Grabar Todo";
            this.btnGrabarTodo.UseVisualStyleBackColor = true;
            this.btnGrabarTodo.Click += new System.EventHandler(this.BtnGrabarTodo_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 553);
            this.Controls.Add(this.btnGrabarTodo);
            this.Controls.Add(distritoLabel);
            this.Controls.Add(this.distritoTextBox);
            this.Controls.Add(this.listaProveedorDataGridView);
            this.Controls.Add(esInternacionalLabel);
            this.Controls.Add(this.esInternacionalCheckBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "FrmProveedor";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.lblContador, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.fechaNacimientoDateTimePicker, 0);
            this.Controls.SetChildIndex(fechaNacimientoLabel, 0);
            this.Controls.SetChildIndex(this.esInternacionalCheckBox, 0);
            this.Controls.SetChildIndex(esInternacionalLabel, 0);
            this.Controls.SetChildIndex(this.listaProveedorDataGridView, 0);
            this.Controls.SetChildIndex(this.distritoTextBox, 0);
            this.Controls.SetChildIndex(distritoLabel, 0);
            this.Controls.SetChildIndex(this.btnGrabarTodo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaProveedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bslistaProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.CheckBox esInternacionalCheckBox;
        private System.Windows.Forms.DataGridView listaProveedorDataGridView;
        private System.Windows.Forms.BindingSource bslistaProveedor;
        private System.Windows.Forms.TextBox distritoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnGrabarTodo;
    }
}