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
    public partial class AltaDietaPacFrm : Form
    {
        Form ventanaPrincipal;

        public AltaDietaPacFrm(Form ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (this.validaCampos())
            {
                Paciente paciente = new Paciente();
                paciente.findbykey(this.dniBox.Text);
                Dieta dieta = new Dieta();
                dieta.findbykey(this.codDietaBox.Text);



            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.restaurarVentanaPrincipal();
            this.Dispose();
        }

        //
        // Valida los campos.
        //
        private bool validaCampos()
        {
            bool valido = true;
            int numero;

            if (String.IsNullOrEmpty(dniBox.Text))
            {
                errorDni.SetError(dniBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (!int.TryParse(dniBox.Text, out numero))
            {
                errorDni.SetError(dniBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                errorDni.SetError(dniBox, String.Empty);
            }

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
