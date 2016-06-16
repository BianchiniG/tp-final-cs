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
    public partial class PpalFrm : Form
    {
        BuscaTodosProfUC buscaTodosProf;
        BuscaDniProfUC buscaProfDni;

        public PpalFrm()
        {
            InitializeComponent();
        }

        #region Eventos de la Barra de Menu
        //
        // Alta de un paciente.
        //
        private void altaDeUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPacFrm altaPacFrm = new AltaPacFrm(this);
            this.bloqueaUI();
            altaPacFrm.Show();
        }

        //
        // Asignar Dieta a Paciente.
        //
        private void asignarDietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDietaPacFrm dietaPac = new AltaDietaPacFrm(this);
            dietaPac.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Alta de un profesional.
        //
        private void altaDeUnProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaProfFrm altaProfFrm = new AltaProfFrm(this);
            this.bloqueaUI();
            altaProfFrm.Show();
        }

        //
        // Asignar un Paciente a un Profesional.
        //
        private void asignarUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPacProfFrm pacProf = new AltaPacProfFrm(this);
            pacProf.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Alta de una Dieta.
        //
        private void altaDeUnaDietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDietaFrm altaDietaFrm = new AltaDietaFrm(this);
            this.bloqueaUI();
            altaDietaFrm.Show();
        }

        //
        // Asignar un Plato a una Dieta.
        //
        private void asignarUnPlatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPlatoDietaFrm platoDieta = new AltaPlatoDietaFrm(this);
            platoDieta.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Alta de un plato.
        //
        private void altaDeUnPlatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPlatoFrm altaPlatoFrm = new AltaPlatoFrm(this);
            this.bloqueaUI();
            altaPlatoFrm.Show();
        }

        //
        // Asignar un Ingrediente a un Plato.
        //
        private void asignarUnIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPlatoIngrFrm platoIngr = new AltaPlatoIngrFrm(this);
            platoIngr.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Alta de un ingrediente.
        //
        private void altaDeUnIngredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaIngrFrm altaIngrFrm = new AltaIngrFrm(this);
            this.bloqueaUI();
            altaIngrFrm.Show();
        }

        //
        // Busqueda de todos los profesionales.
        //
        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.buscaTodosProf = new BuscaTodosProfUC(this);
            this.buscaTodosProf.Dock = DockStyle.Fill;
            this.principalBox.Controls.Add(this.buscaTodosProf);
            this.buscaTodosProf.Visible = true;
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Busqueda de profesionales por Dni.
        //
        private void profDniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.buscaProfDni = new BuscaDniProfUC(this);
            this.buscaProfDni.Dock = DockStyle.Fill;
            this.principalBox.Controls.Add(this.buscaProfDni);
            this.buscaProfDni.Visible = true;
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }
        #endregion

        #region Eventos de los Botones
        //
        // Boton Alta Paciente
        //
        private void botonAltaPac_Click(object sender, EventArgs e)
        {
            AltaPacFrm pacFrm = new AltaPacFrm(this);
            pacFrm.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Boton Alta Profesional
        //
        private void botonAltaProf_Click(object sender, EventArgs e)
        {
            AltaProfFrm prof = new AltaProfFrm(this);
            prof.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Boton Alta Dieta
        //
        private void botonAltaDieta_Click(object sender, EventArgs e)
        {
            AltaDietaFrm diet = new AltaDietaFrm(this);
            diet.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Boton Alta Plato
        //
        private void botonAltaPlato_Click(object sender, EventArgs e)
        {
            AltaPlatoFrm plato = new AltaPlatoFrm(this);
            plato.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }

        //
        // Boton Alta Ingrediente
        //
        private void botonAltaIngr_Click(object sender, EventArgs e)
        {
            AltaIngrFrm ingr = new AltaIngrFrm(this);
            ingr.Show();
            // Bloquea los botones y la barra de menu.
            this.bloqueaUI();
        }
        
        //
        // Boton Salir
        //
        private void botonSalir_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Desea salir del sistema?", "Salir...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (ret == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }
        #endregion

        #region Otros Métodos
        //
        // Inhabilita los controles de la ventana principal.
        //
        private void bloqueaUI()
        {
            this.botonAltaProf.Enabled = false;
            this.botonAltaPac.Enabled = false;
            this.botonAltaDieta.Enabled = false;
            this.botonAltaPlato.Enabled = false;
            this.botonAltaIngr.Enabled = false;
            this.menuStrip1.Enabled = false;
        }
        #endregion
        
        //
        // Buscar a todos los pacientes.
        //
        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar pacientes por DNI.
        //
        private void porDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar todos los pacientes asignados a un médico.
        //
        private void asignadosAUnMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar todas las dietas
        //
        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar las dietas asignadas a un paciente.
        //
        private void asignadasAUnPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar todos los platos.
        //
        private void todosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar los platos asignados a una dieta.
        //
        private void asignadosAUnaDietaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar todos los ingredientes.
        //
        private void todosToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        //
        // Buscar los ingredientes asignados a un plato.
        //
        private void asignadosAUnPlatoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
