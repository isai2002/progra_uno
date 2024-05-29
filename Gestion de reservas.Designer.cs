namespace ProyectoFinal1
{
	partial class Solicitudes
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proyectoPrograDataSet = new ProyectoFinal1.ProyectoPrograDataSet();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.cmbEnviar = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.reservacionTableAdapter = new ProyectoFinal1.ProyectoPrograDataSetTableAdapters.ReservacionTableAdapter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.proyectoProgramacionDataSet1 = new ProyectoFinal1.ProyectoProgramacionDataSet1();
			this.reservacionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.reservacionTableAdapter1 = new ProyectoFinal1.ProyectoProgramacionDataSet1TableAdapters.ReservacionTableAdapter();
			this.idReservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoCanchaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoPrograDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proyectoProgramacionDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservacionDataGridViewTextBoxColumn,
            this.tipoCanchaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.carnetDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.reservacionBindingSource1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 18);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(882, 362);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// reservacionBindingSource
			// 
			this.reservacionBindingSource.DataMember = "Reservacion";
			this.reservacionBindingSource.DataSource = this.proyectoPrograDataSet;
			// 
			// proyectoPrograDataSet
			// 
			this.proyectoPrograDataSet.DataSetName = "ProyectoPrograDataSet";
			this.proyectoPrograDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(264, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 38);
			this.label1.TabIndex = 1;
			this.label1.Text = "Reservaciones Actuales";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(24, 444);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(584, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Solicitudes de modificaciones o eliminacion de su reserva? ";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(29, 533);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(270, 27);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Ingrese el id de su reserva";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(317, 533);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(485, 27);
			this.textBox2.TabIndex = 5;
			this.textBox2.Text = "Ingrese la solicitud de lo que desea (Eliminar, modificar)";
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
			// 
			// cmbEnviar
			// 
			this.cmbEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEnviar.Location = new System.Drawing.Point(29, 587);
			this.cmbEnviar.Name = "cmbEnviar";
			this.cmbEnviar.Size = new System.Drawing.Size(85, 31);
			this.cmbEnviar.TabIndex = 6;
			this.cmbEnviar.Text = "Enviar";
			this.cmbEnviar.UseVisualStyleBackColor = true;
			this.cmbEnviar.Click += new System.EventHandler(this.cmbEnviar_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(727, 626);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 38);
			this.button1.TabIndex = 7;
			this.button1.Text = "Regresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(855, 626);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 38);
			this.button2.TabIndex = 8;
			this.button2.Text = "Salir";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// reservacionTableAdapter
			// 
			this.reservacionTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(888, 383);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// proyectoProgramacionDataSet1
			// 
			this.proyectoProgramacionDataSet1.DataSetName = "ProyectoProgramacionDataSet1";
			this.proyectoProgramacionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reservacionBindingSource1
			// 
			this.reservacionBindingSource1.DataMember = "Reservacion";
			this.reservacionBindingSource1.DataSource = this.proyectoProgramacionDataSet1;
			// 
			// reservacionTableAdapter1
			// 
			this.reservacionTableAdapter1.ClearBeforeFill = true;
			// 
			// idReservacionDataGridViewTextBoxColumn
			// 
			this.idReservacionDataGridViewTextBoxColumn.DataPropertyName = "IdReservacion";
			this.idReservacionDataGridViewTextBoxColumn.HeaderText = "IdReservacion";
			this.idReservacionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idReservacionDataGridViewTextBoxColumn.Name = "idReservacionDataGridViewTextBoxColumn";
			this.idReservacionDataGridViewTextBoxColumn.ReadOnly = true;
			this.idReservacionDataGridViewTextBoxColumn.Width = 125;
			// 
			// tipoCanchaDataGridViewTextBoxColumn
			// 
			this.tipoCanchaDataGridViewTextBoxColumn.DataPropertyName = "TipoCancha";
			this.tipoCanchaDataGridViewTextBoxColumn.HeaderText = "TipoCancha";
			this.tipoCanchaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tipoCanchaDataGridViewTextBoxColumn.Name = "tipoCanchaDataGridViewTextBoxColumn";
			this.tipoCanchaDataGridViewTextBoxColumn.ReadOnly = true;
			this.tipoCanchaDataGridViewTextBoxColumn.Width = 125;
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
			this.nombreDataGridViewTextBoxColumn.Width = 125;
			// 
			// carnetDataGridViewTextBoxColumn
			// 
			this.carnetDataGridViewTextBoxColumn.DataPropertyName = "Carnet";
			this.carnetDataGridViewTextBoxColumn.HeaderText = "Carnet";
			this.carnetDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.carnetDataGridViewTextBoxColumn.Name = "carnetDataGridViewTextBoxColumn";
			this.carnetDataGridViewTextBoxColumn.ReadOnly = true;
			this.carnetDataGridViewTextBoxColumn.Width = 125;
			// 
			// fechaDataGridViewTextBoxColumn
			// 
			this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
			this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
			this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
			this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
			this.fechaDataGridViewTextBoxColumn.Width = 125;
			// 
			// horaDataGridViewTextBoxColumn
			// 
			this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
			this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
			this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
			this.horaDataGridViewTextBoxColumn.ReadOnly = true;
			this.horaDataGridViewTextBoxColumn.Width = 125;
			// 
			// Solicitudes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkRed;
			this.ClientSize = new System.Drawing.Size(959, 676);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmbEnviar);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Solicitudes";
			this.Text = "Gestión de reservas";
			this.Load += new System.EventHandler(this.Solicitudes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoPrograDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.proyectoProgramacionDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button cmbEnviar;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private ProyectoPrograDataSet proyectoPrograDataSet;
		private System.Windows.Forms.BindingSource reservacionBindingSource;
		private ProyectoPrograDataSetTableAdapters.ReservacionTableAdapter reservacionTableAdapter;
		private System.Windows.Forms.GroupBox groupBox1;
		private ProyectoProgramacionDataSet1 proyectoProgramacionDataSet1;
		private System.Windows.Forms.BindingSource reservacionBindingSource1;
		private ProyectoProgramacionDataSet1TableAdapters.ReservacionTableAdapter reservacionTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idReservacionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoCanchaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn carnetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
	}
}