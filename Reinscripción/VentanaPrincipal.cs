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

namespace Reinscripción
{
    public partial class VentanaPrincipal : Form
    {
        public int elID { get; set; }
        private string connectionString = "Server=localhost;Database=DS3_Materias;Integrated Security=true;";

        public VentanaPrincipal()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvReinscripcion.Columns.Clear();
            dgvReinscripcion.Rows.Clear();

            dgvReinscripcion.Columns.Add("IDMateria", "ID");
            dgvReinscripcion.Columns.Add("NombreMateria", "Nombre");
            dgvReinscripcion.Columns.Add("Tipo", "Tipo");
            dgvReinscripcion.Columns.Add("Horario", "Horario");
            dgvReinscripcion.Columns.Add("Calificacion", "Calificación");
        }

        private void tsbObtener_Click(object sender, EventArgs e)
        {
            CargarMateriasDesdeBD();
        }

        private void CargarMateriasDesdeBD()
        {
            try
            {
                dgvReinscripcion.Rows.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT IDMateria, NombreMateria, Tipo, Horario, Calificacion FROM Materia";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvReinscripcion.Rows.Add(
                            reader["IDMateria"],
                            reader["NombreMateria"],
                            reader["Tipo"],
                            reader["Horario"],
                            reader["Calificacion"]
                        );
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar materias: {ex.Message}");
            }
        }

        private void tsbAgregarNuevaVentana_Click(object sender, EventArgs e)
        {
            Materia nuevo = new Materia();

            AgregarEditar ventanaMateria = new AgregarEditar(nuevo);
            if (ventanaMateria.ShowDialog() == DialogResult.OK)
            {
                if (!ValidarHorarioDisponible(nuevo.Horario))
                {
                    MessageBox.Show("El horario ya está ocupado por otra materia", "Error");
                    return;
                }

                if (AgregarMateriaBD(nuevo))
                {
                    CargarMateriasDesdeBD();
                }
            }
        }

        private bool AgregarMateriaBD(Materia materia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Materia (NombreMateria, Tipo, Horario, Calificacion) 
                                   VALUES (@Nombre, @Tipo, @Horario, @Calificacion)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", materia.NombreMateria);
                    command.Parameters.AddWithValue("@Tipo", materia.Tipo);
                    command.Parameters.AddWithValue("@Horario", materia.Horario);
                    command.Parameters.AddWithValue("@Calificacion", materia.Calificacion);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar materia: {ex.Message}");
                return false;
            }
        }

        private void tsbEditarNuevaVentana_Click(object sender, EventArgs e)
        {
            if (dgvReinscripcion.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvReinscripcion.SelectedRows[0];
                Materia editar = new Materia()
                {
                    ID = Convert.ToInt32(fila.Cells["IDMateria"].Value),
                    NombreMateria = fila.Cells["NombreMateria"].Value.ToString(),
                    Tipo = fila.Cells["Tipo"].Value.ToString(),
                    Horario = fila.Cells["Horario"].Value.ToString(),
                    Calificacion = Convert.ToDecimal(fila.Cells["Calificacion"].Value)
                };

                AgregarEditar ventana = new AgregarEditar(editar);
                if (ventana.ShowDialog() == DialogResult.OK)
                {
                    if (!ValidarHorarioDisponible(editar.Horario, editar.ID))
                    {
                        MessageBox.Show("El horario ya está ocupado por otra materia", "Error");
                        return;
                    }

                    if (ActualizarMateriaBD(editar))
                    {
                        CargarMateriasDesdeBD(); 
                    }
                }
            }
        }

        private bool ActualizarMateriaBD(Materia materia)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Materia SET 
                                   NombreMateria = @Nombre, 
                                   Tipo = @Tipo, 
                                   Horario = @Horario, 
                                   Calificacion = @Calificacion 
                                   WHERE IDMateria = @ID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", materia.NombreMateria);
                    command.Parameters.AddWithValue("@Tipo", materia.Tipo);
                    command.Parameters.AddWithValue("@Horario", materia.Horario);
                    command.Parameters.AddWithValue("@Calificacion", materia.Calificacion);
                    command.Parameters.AddWithValue("@ID", materia.ID);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar materia: {ex.Message}");
                return false;
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReinscripcion.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Eliminar esta materia?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idMateria = Convert.ToInt32(dgvReinscripcion.SelectedRows[0].Cells["IDMateria"].Value);

                    if (EliminarMateriaBD(idMateria))
                    {
                        dgvReinscripcion.Rows.Remove(dgvReinscripcion.SelectedRows[0]);
                    }
                }
            }
        }

        private bool EliminarMateriaBD(int idMateria)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Materia WHERE IDMateria = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", idMateria);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar materia: {ex.Message}");
                return false;
            }
        }

        private bool ValidarHorarioDisponible(string horario, int? idExcluir = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Materia WHERE Horario = @Horario";

                    if (idExcluir.HasValue)
                        query += " AND IDMateria != @ID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Horario", horario);

                    if (idExcluir.HasValue)
                        command.Parameters.AddWithValue("@ID", idExcluir.Value);

                    int count = (int)command.ExecuteScalar();
                    return count == 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar horario: {ex.Message}");
                return false;
            }
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e) { }
        private void dgvReinscripcion_CellContentClick(object sender, EventArgs e) { }
        private void tsbSalir_Click(object sender, EventArgs e) { this.Close(); }
        private void dgvReinscripcion_MouseClick(object sender, MouseEventArgs e) { }
    }
}