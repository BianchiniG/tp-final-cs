using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinNutricion.Formularios
{
    public partial class AltaPacProfFrm : Form
    {
        Form ventanaPrincipal;

        public AltaPacProfFrm(Form ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                this.Dispose();
                this.restaurarVentanaPrincipal();
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.restaurarVentanaPrincipal();
        }

        //
        // Valida los campos.
        //
        private bool validaCampos()
        {
            bool valido = true;
            int numero;

            if (String.IsNullOrEmpty(dniProfBox.Text))
            {
                errorDniProf.SetError(dniProfBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(dniProfBox.Text, out numero))
            {
                errorDniProf.SetError(dniProfBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorDniProf.SetError(dniProfBox, String.Empty);
            }

            if (String.IsNullOrEmpty(dniPacBox.Text))
            {
                errorDniPac.SetError(dniPacBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(dniPacBox.Text, out numero))
            {
                errorDniPac.SetError(dniPacBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorDniPac.SetError(dniPacBox, String.Empty);
            }

            return valido;
        }

        private void restaurarVentanaPrincipal()
        {
            foreach (Control control in this.ventanaPrincipal.Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
