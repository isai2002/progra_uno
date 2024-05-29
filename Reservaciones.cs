using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoFinal1
{
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login v2 = new Login();
            v2.Show();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			string connectionString = "server=DESKTOP-KP5I9CP; database=ProyectoProgramacion; integrated security=true";
			string tipoCancha = txtTipoCancha.Text;
			string nombre = txtNombre.Text;
			string carnet = maskedCarnet.Text;


			DateTime fecha;
			TimeSpan hora;


			if (!DateTime.TryParse(maskedFecha.Text, out fecha))
			{
				MessageBox.Show("Fecha inválida.");
				return;
			}
			if (!TimeSpan.TryParse(maskedHora.Text, out hora))
			{
				MessageBox.Show("Hora inválida.");
				return;
			}
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				con.Open();

				// Consulta para verificar si ya existe una reserva a la misma hora y en el mismo tipo de cancha
				string checkQuery = "SELECT COUNT(*) FROM reservacion WHERE TipoCancha = @TipoCancha AND Fecha = @Fecha AND Hora = @Hora";
				using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
				{
					checkCmd.Parameters.AddWithValue("@TipoCancha", tipoCancha);
					checkCmd.Parameters.AddWithValue("@Fecha", fecha);
					checkCmd.Parameters.AddWithValue("@Hora", hora);

					int count = (int)checkCmd.ExecuteScalar();
					if (count > 0)
					{
						MessageBox.Show("Ya existe una reserva para este tipo de cancha en la misma fecha y hora.");
						return;
					}
				}
				con.Close();
			}
			using (SqlConnection con = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO reservacion (TipoCancha, Fecha, Hora, Nombre, Carnet) VALUES (@TipoCancha, @Fecha, @Hora, @Nombre, @Carnet)";

				using (SqlCommand cmd = new SqlCommand(query, con))
				{
					cmd.Parameters.AddWithValue("@TipoCancha", tipoCancha);
					cmd.Parameters.AddWithValue("@Fecha", fecha);
					cmd.Parameters.AddWithValue("@Hora", hora);
					cmd.Parameters.AddWithValue("@Nombre", nombre);
					cmd.Parameters.AddWithValue("@Carnet", carnet);

					try
					{
						con.Open();
						cmd.ExecuteNonQuery();
						MessageBox.Show("Reserva guardada exitosamente.");
					}
					catch (SqlException ex)
					{
						MessageBox.Show("Error al guardar la reserva: " + ex.Message);

					}
				}
			}
		}

		private void txtTipoCancha_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form Solicitudes = new Solicitudes();
			Solicitudes.Show();
		}
	}
}
