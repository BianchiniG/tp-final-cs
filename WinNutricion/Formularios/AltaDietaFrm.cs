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
    public partial class AltaDietaFrm : Form
    {
        Form ventanaPrincipal;

        public AltaDietaFrm(Form ventana)
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
                DateTime fechaActual = DateTime.Today;
                Dieta dieta = new Dieta();
                dieta.Autor = this.autorBox.Text;
                dieta.Nombre = this.nombreBox.Text;
                dieta.Descripcion = this.descripcionTextBox.Text;
                dieta.FechaAlta = fechaActual;
                dieta.saveObj();
                this.restaurarVentanaPrincipal();
                this.Dispose();
            }
        }

        private bool validaCampos()
        {
            bool valido = true;
            int numero;

            //
            // Valida Autor
            //
            if (String.IsNullOrEmpty(autorBox.Text))
            {
                autorError.SetError(autorBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(autorBox.Text, out numero))
            {
                autorError.SetError(autorBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                autorError.SetError(autorBox, String.Empty);
            }

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
            if (String.IsNullOrEmpty(descripcionTextBox.Text))
            {
                descripcionError.SetError(descripcionTextBox, "El campo no puede estar vacío");
                valido = false;
            }
            else if (int.TryParse(descripcionTextBox.Text, out numero))
            {
                descripcionError.SetError(descripcionTextBox, "El campo no puede ser numérico");
                valido = false;
            }
            else
            {
                descripcionError.SetError(descripcionTextBox, String.Empty);
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
