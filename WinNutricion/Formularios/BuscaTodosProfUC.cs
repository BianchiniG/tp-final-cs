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
    public partial class BuscaTodosProfUC : UserControl
    {
        Form ventanaPpal;

        public BuscaTodosProfUC(Form form)
        {
            InitializeComponent();
            this.ventanaPpal = form;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.tabla.AutoGenerateColumns = false;
            this.tabla.DataSource = ManagerDB<Profesional>.findAll();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.cerrarUC();
        }

        private void cerrarUC()
        {
            foreach (Control control in this.ventanaPpal.Controls)
            {
                control.Enabled = true;
            }
            this.Dispose();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
