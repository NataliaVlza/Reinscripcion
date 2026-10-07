using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reinscripción
{
    public partial class AgregarEditar : Form
    {
        public Materia LaMateria { get; set; }

        public AgregarEditar(Materia materia)
        {
            InitializeComponent();
            LaMateria = materia;

            if (cbTipoMateria.Items.Count == 0)
            {
                cbTipoMateria.Items.Add("Obligatoria");
                cbTipoMateria.Items.Add("Optativa");
                cbTipoMateria.Items.Add("Eje Formacion Comun");
            }

            CargarDatosMateria();
        }

        private void CargarDatosMateria()
        {
            try
            {
                if (LaMateria.ID > 0)
                {
                    this.Text = "Editar Materia";
                    txtID.Text = LaMateria.ID.ToString();

                    if (!string.IsNullOrEmpty(LaMateria.NombreMateria))
                        txtNombreMateria.Text = LaMateria.NombreMateria;

                    if (!string.IsNullOrEmpty(LaMateria.Tipo))
                        cbTipoMateria.SelectedItem = LaMateria.Tipo;

                    if (!string.IsNullOrEmpty(LaMateria.Horario))
                        txtHorario.Text = LaMateria.Horario;

                    nupCalificacion.Value = LaMateria.Calificacion;
                }
                else
                {
                    this.Text = "Agregar Materia";
                    txtID.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void AgregarEditar_Load(object sender, EventArgs e) { }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreMateria.Text))
                {
                    MessageBox.Show("No se permite registrar materias sin nombre");
                    txtNombreMateria.Focus();
                    return;
                }

                if (cbTipoMateria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un tipo de materia.");
                    cbTipoMateria.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtHorario.Text))
                {
                    MessageBox.Show("Ingrese un horario.");
                    txtHorario.Focus();
                    return;
                }

                if (nupCalificacion.Value < 0 || nupCalificacion.Value > 10)
                {
                    MessageBox.Show("La calificacion debe ser un numero entre 0 y 10.");
                    nupCalificacion.Focus();
                    return;
                }

                LaMateria.NombreMateria = txtNombreMateria.Text;
                LaMateria.Tipo = cbTipoMateria.SelectedItem.ToString();
                LaMateria.Horario = txtHorario.Text;
                LaMateria.Calificacion = nupCalificacion.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LaMateria.ID = -1;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}