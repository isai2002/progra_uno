namespace ProyectoFinal1
{
    partial class Reservaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservaciones));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.maskedCarnet = new System.Windows.Forms.MaskedTextBox();
			this.maskedHora = new System.Windows.Forms.MaskedTextBox();
			this.maskedFecha = new System.Windows.Forms.MaskedTextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTipoCancha = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(23, 466);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Size = new System.Drawing.Size(204, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Cerrar Sesion";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Maroon;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(56, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cancha:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(201, 28);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(217, 198);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Maroon;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(56, 277);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nombre:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Maroon;
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(56, 318);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 26);
			this.label4.TabIndex = 6;
			this.label4.Text = "Carnet:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Maroon;
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(61, 362);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 26);
			this.label5.TabIndex = 7;
			this.label5.Text = "Fecha:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Maroon;
			this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(61, 406);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "Hora:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(237, 466);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Size = new System.Drawing.Size(181, 44);
			this.button2.TabIndex = 9;
			this.button2.Text = "Reservar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.maskedCarnet);
			this.groupBox1.Controls.Add(this.maskedHora);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.maskedFecha);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.txtTipoCancha);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(-3, -1);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(663, 601);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Reservaciones";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(444, 444);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(188, 69);
			this.button3.TabIndex = 15;
			this.button3.Text = "Gestionar Reservas";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// maskedCarnet
			// 
			this.maskedCarnet.Location = new System.Drawing.Point(156, 314);
			this.maskedCarnet.Margin = new System.Windows.Forms.Padding(4);
			this.maskedCarnet.Mask = "00-0000-0000";
			this.maskedCarnet.Name = "maskedCarnet";
			this.maskedCarnet.Size = new System.Drawing.Size(300, 30);
			this.maskedCarnet.TabIndex = 14;
			// 
			// maskedHora
			// 
			this.maskedHora.Location = new System.Drawing.Point(156, 404);
			this.maskedHora.Margin = new System.Windows.Forms.Padding(4);
			this.maskedHora.Mask = "00:00";
			this.maskedHora.Name = "maskedHora";
			this.maskedHora.Size = new System.Drawing.Size(300, 30);
			this.maskedHora.TabIndex = 13;
			this.maskedHora.ValidatingType = typeof(System.DateTime);
			// 
			// maskedFecha
			// 
			this.maskedFecha.Location = new System.Drawing.Point(156, 362);
			this.maskedFecha.Margin = new System.Windows.Forms.Padding(4);
			this.maskedFecha.Mask = "00/00/0000";
			this.maskedFecha.Name = "maskedFecha";
			this.maskedFecha.Size = new System.Drawing.Size(300, 30);
			this.maskedFecha.TabIndex = 12;
			this.maskedFecha.ValidatingType = typeof(System.DateTime);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(156, 273);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 30);
			this.txtNombre.TabIndex = 10;
			// 
			// txtTipoCancha
			// 
			this.txtTipoCancha.Location = new System.Drawing.Point(156, 233);
			this.txtTipoCancha.Margin = new System.Windows.Forms.Padding(4);
			this.txtTipoCancha.Name = "txtTipoCancha";
			this.txtTipoCancha.Size = new System.Drawing.Size(300, 30);
			this.txtTipoCancha.TabIndex = 9;
			this.txtTipoCancha.TextChanged += new System.EventHandler(this.txtTipoCancha_TextChanged);
			// 
			// Reservaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(654, 524);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Reservaciones";
			this.Text = "Reservacion";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedHora;
        private System.Windows.Forms.MaskedTextBox maskedFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipoCancha;
        private System.Windows.Forms.MaskedTextBox maskedCarnet;
		private System.Windows.Forms.Button button3;
	}
}