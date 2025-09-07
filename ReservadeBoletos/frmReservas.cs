using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservadeBoletos
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.Add("Acción");
            cmbCategoria.Items.Add("Comedia");
            cmbCategoria.Items.Add("Drama");
            cmbCategoria.Items.Add("Terror");
            cmbCategoria.Items.Add("Aventura");
            cmbCategoria.Items.Add("Romance");
            cmbCategoria.Items.Add("Ciencia Ficción");
            
            txtNombre.Clear();
            txtDUI.Clear();
            txtCantidadBoletos.Clear();
            cmbCategoria.SelectedIndex = -1;
            cmbPelicula.Items.Clear();
            cmbPelicula.SelectedIndex = -1;
            btnAgregar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDUI.Text) || txtDUI.Text.Length != 10)
            {
                MessageBox.Show("Debe ingresar un DUI válido (10 dígitos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDUI.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return;
            }

            if (cmbPelicula.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una película.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPelicula.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCantidadBoletos.Text) || !int.TryParse(txtCantidadBoletos.Text, out int cantidad) || cantidad < 1)
            {
                MessageBox.Show("Debe ingresar una cantidad válida de boletos (mínimo 1).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidadBoletos.Focus();
                return;
            }

            try
            {
                dgvReservas.Rows.Add(txtNombre.Text, txtDUI.Text, cmbCategoria.Text, cmbPelicula.Text, txtCantidadBoletos.Text);
                dgvReservas.Refresh();
                
                txtNombre.Clear();
                txtDUI.Clear();
                txtCantidadBoletos.Clear();
                cmbCategoria.SelectedIndex = -1;
                cmbPelicula.Items.Clear();
                cmbPelicula.SelectedIndex = -1;
                btnAgregar.Enabled = true;
                
                MessageBox.Show("Reserva agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la reserva: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPelicula.Items.Clear();
            cmbPelicula.SelectedIndex = -1;

            if (cmbCategoria.SelectedIndex != -1)
            {
                switch (cmbCategoria.Text)
                {
                    case "Acción":
                        cmbPelicula.Items.Add("Avengers: Endgame");
                        cmbPelicula.Items.Add("John Wick 4");
                        cmbPelicula.Items.Add("Fast & Furious 10");
                        cmbPelicula.Items.Add("Mission Impossible 7");
                        break;
                    case "Comedia":
                        cmbPelicula.Items.Add("Superbad");
                        cmbPelicula.Items.Add("The Hangover");
                        cmbPelicula.Items.Add("Deadpool 3");
                        cmbPelicula.Items.Add("Ted");
                        break;
                    case "Drama":
                        cmbPelicula.Items.Add("The Shawshank Redemption");
                        cmbPelicula.Items.Add("Forrest Gump");
                        cmbPelicula.Items.Add("The Godfather");
                        cmbPelicula.Items.Add("Schindler's List");
                        break;
                    case "Terror":
                        cmbPelicula.Items.Add("The Exorcist");
                        cmbPelicula.Items.Add("Halloween");
                        cmbPelicula.Items.Add("A Nightmare on Elm Street");
                        cmbPelicula.Items.Add("The Conjuring");
                        break;
                    case "Aventura":
                        cmbPelicula.Items.Add("Indiana Jones 5");
                        cmbPelicula.Items.Add("Pirates of the Caribbean 6");
                        cmbPelicula.Items.Add("Jurassic World 3");
                        cmbPelicula.Items.Add("The Mummy");
                        break;
                    case "Romance":
                        cmbPelicula.Items.Add("Titanic");
                        cmbPelicula.Items.Add("The Notebook");
                        cmbPelicula.Items.Add("Casablanca");
                        cmbPelicula.Items.Add("Pretty Woman");
                        break;
                    case "Ciencia Ficción":
                        cmbPelicula.Items.Add("Star Wars: Episode IX");
                        cmbPelicula.Items.Add("Blade Runner 2049");
                        cmbPelicula.Items.Add("Interstellar");
                        cmbPelicula.Items.Add("The Matrix Resurrections");
                        break;
                }
            }

            ValidarCampos();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCantidadBoletos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void txtCantidadBoletos_TextChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarCampos();
        }

        private void ValidarCampos()
        {
            bool camposValidos = !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                                !string.IsNullOrWhiteSpace(txtDUI.Text) &&
                                txtDUI.Text.Length == 10 &&
                                !string.IsNullOrWhiteSpace(txtCantidadBoletos.Text) &&
                                int.TryParse(txtCantidadBoletos.Text, out int cantidad) &&
                                cantidad >= 1 &&
                                cmbCategoria.SelectedIndex != -1 &&
                                cmbPelicula.SelectedIndex != -1;

            btnAgregar.Enabled = camposValidos;
        }
    }
}
//AutoEValuacion: 10
//Carlos Manuel Hernandz Rodriguez+