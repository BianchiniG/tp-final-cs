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
    public partial class BuscaDniProfUC : UserControl
    {
        Form ventanaPrincipal;

        public BuscaDniProfUC(Form ventana)
        {
            InitializeComponent();
            this.ventanaPrincipal = ventana;
        }

        #region Eventos de los Botones
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.tabla.AutoGenerateColumns = false;
            if (validaCampos())
            {
                Profesional p = new Profesional();
                p.findbykey(this.dniBox.Text);

                if (p.Nombre == null)
                {
                    DialogResult ret = MessageBox.Show("No se encontró el Profesional", "Resultado de la Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    this.dniBox.Text = "";
                }
                else
                {
                    List<Profesional> profesional = new List<Profesional>();
                    profesional.Add(p);
                    this.tabla.DataSource = profesional;
                }
            }
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.cerrarUC();
        }
        #endregion

        #region Otros Métodos
        //
        // Cierra el UC y vuelve a habilitar los controles de la ventana principal.
        //
        private void cerrarUC()
        {
            foreach (Control control in this.ventanaPrincipal.Controls)
            {
                control.Enabled = true;
            }
            this.Dispose();
        }

        //
        // Validación de campos de ingreso.
        //
        private bool validaCampos()
        {
            int numero;
            bool valido = true;

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

            return valido;
        }
        #endregion

    }
}
