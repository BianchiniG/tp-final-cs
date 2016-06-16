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
    public partial class AltaPlatoDietaFrm : Form
    {
        Form ventanaPrincipal;

        public AltaPlatoDietaFrm(Form ventana)
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

            if (String.IsNullOrEmpty(codDietaBox.Text))
            {
                errorCodDieta.SetError(codDietaBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(codDietaBox.Text, out numero))
            {
                errorCodDieta.SetError(codDietaBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorCodDieta.SetError(codDietaBox, String.Empty);
            }

            if (String.IsNullOrEmpty(codPlatoBox.Text))
            {
                errorCodPlato.SetError(codPlatoBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(codPlatoBox.Text, out numero))
            {
                errorCodPlato.SetError(codPlatoBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorCodPlato.SetError(codPlatoBox, String.Empty);
            }

            return valido;
        }

        //
        // Habilita los controles de la ventana principal.
        //
        private void restaurarVentanaPrincipal()
        {
            foreach (Control control in this.ventanaPrincipal.Controls)
            {
                control.Enabled = true;
            }
        }
    }
}
