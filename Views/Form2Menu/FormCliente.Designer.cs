namespace SoftVentas.Views.Form2Menu
{
    partial class FormCliente
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ventas_softDataSet = new SoftVentas.ventas_softDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ventassoftDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventassoftDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ventas_softDataSet1 = new SoftVentas.ventas_softDataSet1();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new SoftVentas.ventas_softDataSet1TableAdapters.clienteTableAdapter();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_softDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventassoftDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventassoftDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_softDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(286, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "telefono 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "agregar cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "mail";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "nombre";
            // 
            // ventas_softDataSet
            // 
            this.ventas_softDataSet.DataSetName = "ventas_softDataSet";
            this.ventas_softDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIDDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.telefono1DataGridViewTextBoxColumn,
            this.telefono2DataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // ventassoftDataSetBindingSource
            // 
            this.ventassoftDataSetBindingSource.DataSource = this.ventas_softDataSet;
            this.ventassoftDataSetBindingSource.Position = 0;
            // 
            // ventassoftDataSetBindingSource1
            // 
            this.ventassoftDataSetBindingSource1.DataSource = this.ventas_softDataSet;
            this.ventassoftDataSetBindingSource1.Position = 0;
            // 
            // ventas_softDataSet1
            // 
            this.ventas_softDataSet1.DataSetName = "ventas_softDataSet1";
            this.ventas_softDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.ventas_softDataSet1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            this.clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            // 
            // telefono1DataGridViewTextBoxColumn
            // 
            this.telefono1DataGridViewTextBoxColumn.DataPropertyName = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.HeaderText = "Telefono1";
            this.telefono1DataGridViewTextBoxColumn.Name = "telefono1DataGridViewTextBoxColumn";
            // 
            // telefono2DataGridViewTextBoxColumn
            // 
            this.telefono2DataGridViewTextBoxColumn.DataPropertyName = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.HeaderText = "Telefono2";
            this.telefono2DataGridViewTextBoxColumn.Name = "telefono2DataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 343);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventas_softDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventassoftDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventassoftDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_softDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private ventas_softDataSet ventas_softDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ventassoftDataSetBindingSource;
        private System.Windows.Forms.BindingSource ventassoftDataSetBindingSource1;
        private ventas_softDataSet1 ventas_softDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ventas_softDataSet1TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
    }
}