﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinNutricion.Formularios
{
    public partial class AltaPlatoUC : UserControl
    {
        Form ventanaPpal;

        public AltaPlatoUC(Form form)
        {
            InitializeComponent();
            this.ventanaPpal = form;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            cerrarUC();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            cerrarUC();
        }

        private void cerrarUC()
        {
            foreach (Control control in this.ventanaPpal.Controls)
            {
                control.Enabled = true;
            }
            this.Dispose();
        }
    }
}
