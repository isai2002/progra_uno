using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal1
{
    public partial class Login : Form
    {
        Datos cn = new Datos();
        string username, pwd;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoPrograDataSet.Horario' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'proyectoPrograDataSet.Reservacion' Puede moverla o quitarla según sea necesario.
           

        }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            username = text_Usuario.Text;
            pwd = text_Contra.Text;
            /*Validamos que los textBox username y pwd no esten vacios y si lo estan
             se resalta un error*/
            if (string.IsNullOrEmpty(username))
            {

                error.SetError(text_Usuario, "Ingresar un Usuario Valido....");
                text_Usuario.Focus();
            }
            if (string.IsNullOrEmpty(pwd))
            {
                error.SetError(text_Contra, "Ingresar un Contraseña Valido....");

            }
            /*Validamos que el usuario y contraseña ingresados se encuentren en la base de datos*/
            if (cn.conSQL(text_Usuario.Text, text_Contra.Text)==1)
            {
                /*Validamos que el usuario ingresado sea un administrador o usuario normal
                para mostrar Form para admin o un Form normal
                */
            if (text_Usuario.Text == "123" && text_Contra.Text == "123")
                {
                    error.Clear();
                    this.Hide();
                    FormAdmi v2 = new FormAdmi();
                    v2.Show();
                }
                else { 
                error.Clear();
                this.Hide();
                Reservaciones v1 = new Reservaciones();
                v1.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario No Encontrado");
            }
        }

       
    }
}
