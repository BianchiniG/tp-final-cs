using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNutricion.db;

namespace WinNutricion.Formularios
{
    public partial class AltaProfFrm : Form
    {
        Form ventanaPrincipal;

        public AltaProfFrm(Form ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.restaurarVentanaPrincipal();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.validaCampos())
            {
                DateTime fechaAlta = DateTime.Today;
                Profesional profesional = new Profesional();
                profesional.Nombre = this.nombreBox.Text;
                profesional.Apellido = this.apellidoBox.Text;
                profesional.Domicilio = this.domicilioBox.Text;
                profesional.Dni = Convert.ToInt32(this.dniBox.Text);
                profesional.Telefono = this.telefonoBox.Text;
                profesional.EsMedico = this.medicoCheckBox.Checked;
                profesional.EsNutricionista = this.nutriCheckBox.Checked;
                profesional.FechaAlta = fechaAlta;
                profesional.saveObj();
                this.restaurarVentanaPrincipal();
                this.Dispose();
            }
        }

        #region Validaciones de campos
        private bool validaCampos()
        {
            bool valido = true;
            int numero;

            if (String.IsNullOrEmpty(nombreBox.Text))
            {
                nombreError.SetError(nombreBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(nombreBox.Text, out numero))
            {
                nombreError.SetError(nombreBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                nombreError.SetError(nombreBox, String.Empty);
            }

            if (String.IsNullOrEmpty(apellidoBox.Text))
            {
                apellidoError.SetError(apellidoBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(apellidoBox.Text, out numero))
            {
                apellidoError.SetError(apellidoBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                apellidoError.SetError(apellidoBox, String.Empty);
            }

            if (String.IsNullOrEmpty(domicilioBox.Text))
            {
                domicilioError.SetError(domicilioBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(domicilioBox.Text, out numero))
            {
                domicilioError.SetError(domicilioBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                domicilioError.SetError(domicilioBox, String.Empty);
            }

            if (String.IsNullOrEmpty(dniBox.Text))
            {
                dniError.SetError(dniBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(dniBox.Text, out numero))
            {
                dniError.SetError(dniBox, "El campo debe ser numérico");
                valido = false;
            }
            else
            {
                dniError.SetError(dniBox, String.Empty);
            }

            if (String.IsNullOrEmpty(telefonoBox.Text))
            {
                telefonoError.SetError(telefonoBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(telefonoBox.Text, out numero))
            {
                telefonoError.SetError(telefonoBox, "El campo debe ser numérico");
                valido = false;
            }
            else
            {
                telefonoError.SetError(telefonoBox, String.Empty);
            }

            return valido;

        }
        #endregion

        private void restaurarVentanaPrincipal()
        {
            foreach (Control control in this.ventanaPrincipal.Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
