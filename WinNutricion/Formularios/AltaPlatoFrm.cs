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
    public partial class AltaPlatoFrm : Form
    {
        Form ventanaPrincipal;

        public AltaPlatoFrm(Form ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.restaurarVentanaPrincipal();
            this.Dispose();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                Plato plato = new Plato();
                plato.Nombre = nombreBox.Text;
                plato.Detalle = descripcionBox.Text;
                this.restaurarVentanaPrincipal();
                this.Dispose();
            }
        }

        private bool validaCampos()
        {
            bool valido = true;
            int numero;

            //
            // Valida Nombre
            //
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

            //
            // Valida Descripción
            //
            if (String.IsNullOrEmpty(descripcionBox.Text))
            {
                descripcionError.SetError(descripcionBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(descripcionBox.Text, out numero))
            {
                descripcionError.SetError(descripcionBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                descripcionError.SetError(descripcionBox, String.Empty);
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
