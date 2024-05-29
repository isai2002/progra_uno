using System;
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
    public partial class FormAdmi : Form
    {
        public FormAdmi()
        {
            InitializeComponent();
        }

        private void FormAdmi_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoProgramacionDataSet2.Reservacion' Puede moverla o quitarla según sea necesario.
            this.reservacionTableAdapter.Fill(this.proyectoProgramacionDataSet2.Reservacion);



        }

		private void button2_Click(object sender, EventArgs e)
		{
			string IdReservacion = txtID.Text;
			string nuevoNombre = txtNombre.Text;
			string TipoCancha = txtCancha.Text;
			string nuevaFecha = maskedFecha.Text;
			string nuevaHora = maskedHora.Text;
			string nuevoCarnet = maskedCarnet.Text;

			string query2 = "UPDATE Usuario SET NOMBRE = @NuevoNombre, TipoCancha = @TipoCancha, Fecha = @NuevaFecha, Hora = @NuevaHora, Carnet = @NuevoCarnet WHERE IdReservacion = @IdReservacion";

			using (SqlConnection connection = new SqlConnection("server=DESKTOP-KP5I9CP; database=ProyectoProgramacion; integrated security=true"))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query2, connection))
				{
					command.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
					command.Parameters.AddWithValue("@TipoCancha", TipoCancha);
					command.Parameters.AddWithValue("@NuevaFecha", nuevaFecha);
					command.Parameters.AddWithValue("@NuevaHora", nuevaHora);
					command.Parameters.AddWithValue("@NuevoCarnet", nuevoCarnet);
					command.Parameters.AddWithValue("@IdReservacion", IdReservacion);

					try
					{
						int ACTUALIZAR = command.ExecuteNonQuery();


						if (ACTUALIZAR > 0)
						{
							MessageBox.Show("Registro actualizado correctamente.");
						}
						else
						{
							MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
						}
					}
					catch (SqlException ex)
					{
						MessageBox.Show("Error al actualizar el registro: " + ex.Message);
					}
					connection.Close();
				}
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login v2 = new Login();
			v2.Show();
		}
	}
	}

