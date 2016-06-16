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
    public partial class AltaPacFrm : Form
    {
        Form ventanaPrincipal;

        public AltaPacFrm(Form ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.restaurarVentanaPrincipal();
            this.Dispose();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            if (this.validaCampos())
            {
                DateTime fechaAlta = DateTime.Today;
                Paciente p = new Paciente();
                p.Nombre = this.nombreBox.Text;
                p.Apellido = this.apellidoBox.Text;
                p.Dni = Convert.ToInt32(this.dniBox.Text);
                p.Domicilio = this.direccionBox.Text;
                p.FechaNac = this.fechaDeNacBox.Value;
                p.Telefono = this.telefonoBox.Text;
                p.PesoInicial = float.Parse(this.pesoInicialBox.Text);
                p.Talla = float.Parse(this.tallaBox.Text);
                p.FechaAlta = fechaAlta;
                p.saveObj();
                this.Dispose();
                this.restaurarVentanaPrincipal();
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

            if (String.IsNullOrEmpty(apellidoBox.Text))
            {
                direccionError.SetError(direccionBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(direccionBox.Text, out numero))
            {
                direccionError.SetError(direccionBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                direccionError.SetError(direccionBox, String.Empty);
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

            if (String.IsNullOrEmpty(pesoInicialBox.Text))
            {
                pesoError.SetError(pesoInicialBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(pesoInicialBox.Text, out numero))
            {
                pesoError.SetError(pesoInicialBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                pesoError.SetError(pesoInicialBox, String.Empty);
            }

            if (String.IsNullOrEmpty(tallaBox.Text))
            {
                tallaError.SetError(tallaBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(tallaBox.Text, out numero))
            {
                tallaError.SetError(tallaBox, "El campo debe ser numérico");
                valido = false;
            }
            else
            {
                tallaError.SetError(tallaBox, String.Empty);
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
