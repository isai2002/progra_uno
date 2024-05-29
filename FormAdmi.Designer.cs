namespace ProyectoFinal1
{
    partial class FormAdmi
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCancha = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.maskedCarnet = new System.Windows.Forms.MaskedTextBox();
			this.maskedHora = new System.Windows.Forms.MaskedTextBox();
			this.maskedFecha = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.idReservacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoCanchaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.carnetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proyectoProgramacionDataSet2 = new ProyectoFinal1.ProyectoProgramacionDataSet2();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.reservacionTableAdapter = new ProyectoFinal1.ProyectoProgramacionDataSet2TableAdapters.ReservacionTableAdapter();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoProgramacionDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkRed;
			this.splitContainer1.Panel1.Controls.Add(this.button7);
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer1.Size = new System.Drawing.Size(1253, 716);
			this.splitContainer1.SplitterDistance = 404;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtCancha);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.maskedCarnet);
			this.groupBox1.Controls.Add(this.maskedHora);
			this.groupBox1.Controls.Add(this.maskedFecha);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(0, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(414, 662);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ADMINISTRADOR";
			// 
			// label6
			// 
			this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(205, 35);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(166, 20);
			this.label6.TabIndex = 15;
			this.label6.Text = "TIPO DE CANCHA";
			// 
			// txtCancha
			// 
			this.txtCancha.Location = new System.Drawing.Point(209, 58);
			this.txtCancha.Name = "txtCancha";
			this.txtCancha.Size = new System.Drawing.Size(190, 27);
			this.txtCancha.TabIndex = 14;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.button5);
			this.groupBox3.Controls.Add(this.button4);
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.button1);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(0, 303);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(408, 410);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "GESTION";
			// 
			// button6
			// 
			this.button6.ForeColor = System.Drawing.Color.Black;
			this.button6.Location = new System.Drawing.Point(8, 181);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(343, 37);
			this.button6.TabIndex = 5;
			this.button6.Text = "MOSTRAR CONSULTAS";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Location = new System.Drawing.Point(6, 138);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(343, 37);
			this.button5.TabIndex = 4;
			this.button5.Text = "MOSTRAR RESERVACION";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(129, 95);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(150, 37);
			this.button4.TabIndex = 3;
			this.button4.Text = "EDITAR";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(6, 95);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(117, 37);
			this.button3.TabIndex = 2;
			this.button3.Text = "ELIMINAR";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(129, 37);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(150, 37);
			this.button2.TabIndex = 1;
			this.button2.Text = "ACTUALIZAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(6, 37);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "INGRESAR";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// maskedCarnet
			// 
			this.maskedCarnet.Location = new System.Drawing.Point(17, 270);
			this.maskedCarnet.Mask = "00-0000-0000";
			this.maskedCarnet.Name = "maskedCarnet";
			this.maskedCarnet.Size = new System.Drawing.Size(100, 27);
			this.maskedCarnet.TabIndex = 12;
			// 
			// maskedHora
			// 
			this.maskedHora.Location = new System.Drawing.Point(13, 217);
			this.maskedHora.Mask = "00:00";
			this.maskedHora.Name = "maskedHora";
			this.maskedHora.Size = new System.Drawing.Size(49, 27);
			this.maskedHora.TabIndex = 11;
			this.maskedHora.ValidatingType = typeof(System.DateTime);
			// 
			// maskedFecha
			// 
			this.maskedFecha.Location = new System.Drawing.Point(13, 165);
			this.maskedFecha.Mask = "00/00/0000";
			this.maskedFecha.Name = "maskedFecha";
			this.maskedFecha.Size = new System.Drawing.Size(100, 27);
			this.maskedFecha.TabIndex = 10;
			this.maskedFecha.ValidatingType = typeof(System.DateTime);
			// 
			// label5
			// 
			this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "CARNET";
			// 
			// label4
			// 
			this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 194);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "HORA";
			// 
			// label3
			// 
			this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "FECHA";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(12, 111);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(39, 27);
			this.txtID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID";
			// 
			// label1
			// 
			this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "NOMBRE";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(13, 58);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(190, 27);
			this.txtNombre.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(844, 724);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "RESERVACION";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.BackgroundColor = System.Drawing.Color.DarkRed;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReservacionDataGridViewTextBoxColumn,
            this.tipoCanchaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.carnetDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.reservacionBindingSource;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 18);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 51;
			this.dataGridView2.RowTemplate.Height = 24;
			this.dataGridView2.Size = new System.Drawing.Size(838, 703);
			this.dataGridView2.TabIndex = 0;
			// 
			// idReservacionDataGridViewTextBoxColumn
			// 
			this.idReservacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.idReservacionDataGridViewTextBoxColumn.DataPropertyName = "IdReservacion";
			this.idReservacionDataGridViewTextBoxColumn.HeaderText = "IdReservacion";
			this.idReservacionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.idReservacionDataGridViewTextBoxColumn.Name = "idReservacionDataGridViewTextBoxColumn";
			this.idReservacionDataGridViewTextBoxColumn.ReadOnly = true;
			this.idReservacionDataGridViewTextBoxColumn.Width = 124;
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
			this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
			this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
			this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
			this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
			this.nombreDataGridViewTextBoxColumn.Width = 85;
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
			this.horaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
			this.horaDataGridViewTextBoxColumn.HeaderText = "hora";
			this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
			this.horaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// reservacionBindingSource
			// 
			this.reservacionBindingSource.DataMember = "Reservacion";
			this.reservacionBindingSource.DataSource = this.proyectoProgramacionDataSet2;
			// 
			// proyectoProgramacionDataSet2
			// 
			this.proyectoProgramacionDataSet2.DataSetName = "ProyectoProgramacionDataSet2";
			this.proyectoProgramacionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkRed;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(844, 716);
			this.dataGridView1.TabIndex = 0;
			// 
			// reservacionTableAdapter
			// 
			this.reservacionTableAdapter.ClearBeforeFill = true;
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.Location = new System.Drawing.Point(13, 667);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(190, 37);
			this.button7.TabIndex = 6;
			this.button7.Text = "CERRAR  SESIÓN";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// FormAdmi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1253, 716);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormAdmi";
			this.Text = "FormAdmi";
			this.Load += new System.EventHandler(this.FormAdmi_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoProgramacionDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MaskedTextBox maskedCarnet;
		private System.Windows.Forms.MaskedTextBox maskedHora;
		private System.Windows.Forms.MaskedTextBox maskedFecha;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private ProyectoProgramacionDataSet2 proyectoProgramacionDataSet2;
		private System.Windows.Forms.BindingSource reservacionBindingSource;
		private ProyectoProgramacionDataSet2TableAdapters.ReservacionTableAdapter reservacionTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idReservacionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoCanchaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn carnetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCancha;
		private System.Windows.Forms.Button button7;
	}
}