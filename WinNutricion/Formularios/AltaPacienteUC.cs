using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNutricion.db;

namespace WinNutricion.Formularios
{
    public partial class AltaPacienteUC : UserControl
    {
        Form ventanaPpal;

        public AltaPacienteUC(Form form)
        {
            InitializeComponent();
            this.ventanaPpal = form;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            cerrarUC();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                DateTime fechaAlta = DateTime.Today;
                Paciente p = new Paciente();
                p.Nombre = this.textBoxNombre.Text;
                p.Apellido = this.textBoxApellido.Text;
                p.Dni = Convert.ToInt32(this.textBoxDni.Text);
                p.Domicilio = this.textBoxDomicilio.Text;
                p.FechaNac = this.dateTimePicker.Value;
                p.Telefono = this.textBoxTelefono.Text;
                p.PesoInicial = float.Parse(this.textBoxPesoIni.Text);
                p.Talla = float.Parse(this.textBoxTalla.Text);
                p.FechaAlta = fechaAlta;
                p.saveObj();

                cerrarUC();
            }
        }

        private void cerrarUC()
        {
            foreach (Control control in this.ventanaPpal.Controls)
            {
                control.Enabled = true;
            }
            this.Dispose();
        }

        #region Validaciones de campos
        private bool validaCampos()
        {
            bool valido = true;
            int numero;

            if (String.IsNullOrEmpty(textBoxNombre.Text))
            {
                errorProviderNombre.SetError(textBoxNombre, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(textBoxNombre.Text, out numero))
            {
                errorProviderNombre.SetError(textBoxNombre, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorProviderNombre.SetError(textBoxNombre, String.Empty);
            }

            if (String.IsNullOrEmpty(textBoxApellido.Text))
            {
                errorProviderApellido.SetError(textBoxApellido, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(textBoxApellido.Text, out numero))
            {
                errorProviderApellido.SetError(textBoxApellido, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorProviderApellido.SetError(textBoxApellido, String.Empty);
            }

            if (String.IsNullOrEmpty(textBoxDomicilio.Text))
            {
                errorProviderDomicilio.SetError(textBoxDomicilio, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(textBoxDomicilio.Text, out numero))
            {
                errorProviderDomicilio.SetError(textBoxDomicilio, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorProviderDomicilio.SetError(textBoxDomicilio, String.Empty);
            }

            if (String.IsNullOrEmpty(textBoxDni.Text))
            {
                errorProviderDni.SetError(textBoxDni, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(textBoxDni.Text, out numero))
            {
                errorProviderDni.SetError(textBoxDni, "El campo debe ser numérico");
                valido = false;
            }
            else
            {
                errorProviderDni.SetError(textBoxDni, String.Empty);
            }

            if (String.IsNullOrEmpty(textBoxTelefono.Text))
            {
                errorProviderTelefono.SetError(textBoxTelefono, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(textBoxTelefono.Text, out numero))
            {
                errorProviderTelefono.SetError(textBoxTelefono, "El campo debe ser numérico");
                valido = false;
            }
            else
            {
                errorProviderTelefono.SetError(textBoxTelefono, String.Empty);
            }

            if (String.IsNullOrEmpty(textBoxPesoIni.Text))
            {
                errorProviderPesoIni.SetError(textBoxPesoIni, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(textBoxPesoIni.Text, out numero))
            {
                errorProviderPesoIni.SetError(textBoxPesoIni, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorProviderPesoIni.SetError(textBoxPesoIni, String.Empty);
            }

            if (String.IsNullOrEmpty(textBoxTalla.Text))
            {
                errorProviderTalla.SetError(textBoxTalla, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(textBoxTalla.Text, out numero))
            {
                errorProviderTalla.SetError(textBoxTalla, "El campo debe ser numérico");
                valido = false;
            }
            else
            {
                errorProviderTalla.SetError(textBoxTalla, String.Empty);
            }

            return valido;
        }
        #endregion
    }
}