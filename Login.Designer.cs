namespace ProyectoFinal1
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.text_Usuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.text_Contra = new System.Windows.Forms.TextBox();
			this.btn_Ingresar = new System.Windows.Forms.Button();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.reservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.proyectoPrograDataSet = new ProyectoFinal1.ProyectoPrograDataSet();
			this.error = new System.Windows.Forms.ErrorProvider(this.components);
			this.reservacionTableAdapter = new ProyectoFinal1.ProyectoPrograDataSetTableAdapters.ReservacionTableAdapter();
			this.fKHorarioReservacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.horarioTableAdapter = new ProyectoFinal1.ProyectoPrograDataSetTableAdapters.HorarioTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoPrograDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKHorarioReservacionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 160);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			// 
			// text_Usuario
			// 
			this.text_Usuario.Location = new System.Drawing.Point(23, 180);
			this.text_Usuario.Margin = new System.Windows.Forms.Padding(4);
			this.text_Usuario.Name = "text_Usuario";
			this.text_Usuario.Size = new System.Drawing.Size(240, 22);
			this.text_Usuario.TabIndex = 1;
			this.text_Usuario.Text = "1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 243);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contraseña";
			// 
			// text_Contra
			// 
			this.text_Contra.Location = new System.Drawing.Point(23, 263);
			this.text_Contra.Margin = new System.Windows.Forms.Padding(4);
			this.text_Contra.Name = "text_Contra";
			this.text_Contra.PasswordChar = '*';
			this.text_Contra.Size = new System.Drawing.Size(240, 22);
			this.text_Contra.TabIndex = 3;
			// 
			// btn_Ingresar
			// 
			this.btn_Ingresar.BackColor = System.Drawing.Color.Maroon;
			this.btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
			this.btn_Ingresar.Location = new System.Drawing.Point(23, 342);
			this.btn_Ingresar.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Ingresar.Name = "btn_Ingresar";
			this.btn_Ingresar.Size = new System.Drawing.Size(89, 28);
			this.btn_Ingresar.TabIndex = 4;
			this.btn_Ingresar.Text = "Ingresar";
			this.btn_Ingresar.UseVisualStyleBackColor = false;
			this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
			// 
			// btn_Salir
			// 
			this.btn_Salir.BackColor = System.Drawing.Color.DarkRed;
			this.btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Salir.ForeColor = System.Drawing.Color.White;
			this.btn_Salir.Location = new System.Drawing.Point(165, 342);
			this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(84, 28);
			this.btn_Salir.TabIndex = 5;
			this.btn_Salir.Text = "Salir";
			this.btn_Salir.UseVisualStyleBackColor = false;
			this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(-4, -4);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Brown;
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.btn_Salir);
			this.splitContainer1.Panel1.Controls.Add(this.text_Usuario);
			this.splitContainer1.Panel1.Controls.Add(this.btn_Ingresar);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.text_Contra);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(808, 507);
			this.splitContainer1.SplitterDistance = 292;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(53, 79);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Polideportivo UTEC";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(17, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(273, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "RESERVACION DE CANCHAS ";
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
			// error
			// 
			this.error.ContainerControl = this;
			// 
			// reservacionTableAdapter
			// 
			this.reservacionTableAdapter.ClearBeforeFill = true;
			// 
			// fKHorarioReservacionBindingSource
			// 
			this.fKHorarioReservacionBindingSource.DataMember = "FK_Horario_Reservacion";
			this.fKHorarioReservacionBindingSource.DataSource = this.reservacionBindingSource;
			// 
			// horarioTableAdapter
			// 
			this.horarioTableAdapter.ClearBeforeFill = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(896, 563);
			this.Controls.Add(this.splitContainer1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.reservacionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.proyectoPrograDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKHorarioReservacionBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_Contra;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ErrorProvider error;
        private ProyectoPrograDataSet proyectoPrograDataSet;
        private System.Windows.Forms.BindingSource reservacionBindingSource;
        private ProyectoPrograDataSetTableAdapters.ReservacionTableAdapter reservacionTableAdapter;
        private System.Windows.Forms.BindingSource fKHorarioReservacionBindingSource;
        private ProyectoPrograDataSetTableAdapters.HorarioTableAdapter horarioTableAdapter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}