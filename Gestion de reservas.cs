using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal1
{
	public partial class Solicitudes : Form
	{
		public Solicitudes()
		{
			InitializeComponent();
		}

		private void Solicitudes_Load(object sender, EventArgs e)
		{
			// TODO: esta línea de código carga datos en la tabla 'proyectoProgramacionDataSet1.Reservacion' Puede moverla o quitarla según sea necesario.
			this.reservacionTableAdapter1.Fill(this.proyectoProgramacionDataSet1.Reservacion);
			string connectionString = "server=DESKTOP-KP5I9CP; database=ProyectoProgramacion; integrated security=true";
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();
				string Datos = "SELECT * FROM Reservacion";
				SqlDataAdapter adaptador = new SqlDataAdapter(Datos, con);

				DataTable tabla = new DataTable();

				adaptador.Fill(tabla);
				dataGridView1.DataSource = tabla;
				con.Close();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			
		}

		private void cmbEnviar_Click(object sender, EventArgs e)
		{
			string idUsuario = textBox1.Text;
			string Solicitud = textBox2.Text;
			
			//para verificar que no esten en blanco los datos
			if (string.IsNullOrWhiteSpace(idUsuario) || string.IsNullOrWhiteSpace(Solicitud))
			{
				MessageBox.Show("Por favor, rellene todos los campos.");
				return; 
			}
			string connectionString = "server=DESKTOP-KP5I9CP; database=ProyectoProgramacion; integrated security=true";

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				
				string consulta = "INSERT INTO consultas (idUsuario, Solicitud) VALUES (@idUsuario, @Solicitud)";

				using (SqlCommand cmd = new SqlCommand(consulta, con))
				{ 
					try
					{
						con.Open();
						cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
						cmd.Parameters.AddWithValue("@Solicitud", Solicitud);
						cmd.ExecuteNonQuery();
						MessageBox.Show("Solicitud enviada! La Revisaremos pronto ");
					}
					catch (SqlException ex)
					{
						MessageBox.Show("Error en la solicitud: " + ex.Message);
					}
				}
			
			}

		}


		

		private void textBox1_Enter(object sender, EventArgs e)
		{
			if (textBox1.Text == "Ingrese el id de su reserva")
			{
				textBox1.Text = "";
			}
		}

		private void textBox2_Enter(object sender, EventArgs e)
		{
			if (textBox2.Text == "Ingrese la solicitud de lo que desea (Eliminar, modificar)")
			{
				textBox2.Text = "";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form Regresar = new Reservaciones();
			//Regresar.Show();
			

			Regresar.Owner = this; 
			Regresar.Show();
			this.Close();
		}
	}
}
