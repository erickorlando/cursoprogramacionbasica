namespace SistemaPrestamos
{
    partial class FrmCalcularCuotas
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
            System.Windows.Forms.Label totalAPagarLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label interesLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsProcesoCuotas = new System.Windows.Forms.BindingSource(this.components);
            this.listaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.montoCuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaCuotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.totalAPagarTextBox = new System.Windows.Forms.TextBox();
            this.interesTextBox = new System.Windows.Forms.TextBox();
            totalAPagarLabel = new System.Windows.Forms.Label();
            interesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProcesoCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCuotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalAPagarLabel
            // 
            totalAPagarLabel.AutoSize = true;
            totalAPagarLabel.Location = new System.Drawing.Point(18, 486);
            totalAPagarLabel.Name = "totalAPagarLabel";
            totalAPagarLabel.Size = new System.Drawing.Size(98, 17);
            totalAPagarLabel.TabIndex = 9;
            totalAPagarLabel.Text = "Total a Pagar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProcesoCuotas, "Cliente", true));
            this.comboBox1.DataSource = this.listaClientesBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(344, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Nombre";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bsProcesoCuotas
            // 
            this.bsProcesoCuotas.DataSource = typeof(SistemaPrestamos.ProcesoCuotas);
            // 
            // listaClientesBindingSource
            // 
            this.listaClientesBindingSource.DataSource = typeof(SistemaPrestamos.ListaClientes);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto Préstamo:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcesoCuotas, "MontoPrestamo", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBox1.Location = new System.Drawing.Point(162, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de Cuotas:";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcesoCuotas, "CantidadCuotas", true));
            this.textBox2.Location = new System.Drawing.Point(162, 92);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 23);
            this.textBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.montoCuotaDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.Interes,
            this.Total});
            this.dataGridView1.DataSource = this.listaCuotasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(887, 321);
            this.dataGridView1.TabIndex = 5;
            // 
            // montoCuotaDataGridViewTextBoxColumn
            // 
            this.montoCuotaDataGridViewTextBoxColumn.DataPropertyName = "MontoCuota";
            dataGridViewCellStyle5.Format = "C2";
            this.montoCuotaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.montoCuotaDataGridViewTextBoxColumn.HeaderText = "MontoCuota";
            this.montoCuotaDataGridViewTextBoxColumn.Name = "montoCuotaDataGridViewTextBoxColumn";
            this.montoCuotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago";
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.fechaPagoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            dataGridViewCellStyle7.Format = "C2";
            this.Interes.DefaultCellStyle = dataGridViewCellStyle7;
            this.Interes.HeaderText = "Interes";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle8.Format = "C2";
            this.Total.DefaultCellStyle = dataGridViewCellStyle8;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // listaCuotasBindingSource
            // 
            this.listaCuotasBindingSource.DataMember = "ListaCuotas";
            this.listaCuotasBindingSource.DataSource = this.bsProcesoCuotas;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(673, 119);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(227, 28);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Cuotas a Pagar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(540, 32);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(0, 17);
            this.lblFechaNacimiento.TabIndex = 0;
            // 
            // totalAPagarTextBox
            // 
            this.totalAPagarTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcesoCuotas, "TotalAPagar", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.totalAPagarTextBox.Location = new System.Drawing.Point(162, 483);
            this.totalAPagarTextBox.Name = "totalAPagarTextBox";
            this.totalAPagarTextBox.Size = new System.Drawing.Size(249, 23);
            this.totalAPagarTextBox.TabIndex = 6;
            // 
            // interesLabel
            // 
            interesLabel.AutoSize = true;
            interesLabel.Location = new System.Drawing.Point(18, 125);
            interesLabel.Name = "interesLabel";
            interesLabel.Size = new System.Drawing.Size(55, 17);
            interesLabel.TabIndex = 11;
            interesLabel.Text = "Interes:";
            // 
            // interesTextBox
            // 
            this.interesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProcesoCuotas, "Interes", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.interesTextBox.Location = new System.Drawing.Point(162, 122);
            this.interesTextBox.Name = "interesTextBox";
            this.interesTextBox.Size = new System.Drawing.Size(133, 23);
            this.interesTextBox.TabIndex = 3;
            // 
            // FrmCalcularCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 526);
            this.Controls.Add(interesLabel);
            this.Controls.Add(this.interesTextBox);
            this.Controls.Add(totalAPagarLabel);
            this.Controls.Add(this.totalAPagarTextBox);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCalcularCuotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Cuotas";
            this.Load += new System.EventHandler(this.FrmCalcularCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProcesoCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCuotasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.BindingSource listaClientesBindingSource;
        private System.Windows.Forms.BindingSource bsProcesoCuotas;
        private System.Windows.Forms.BindingSource listaCuotasBindingSource;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoCuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox totalAPagarTextBox;
        private System.Windows.Forms.TextBox interesTextBox;
    }
}