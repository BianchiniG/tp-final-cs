using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql; // Libreria para conectar con PostgreSQL
using LibNutricion.db; // incluir libreria para poder acceder a los objetos de negocios.


namespace WinNutricion
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {            
            InitializeComponent();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {
                var list = ManagerDB<Ingrediente>.findAll();
                //cargar contenido de dropdown                
                this.IngredientesCbo.DisplayMember = "Nombre";
                this.IngredientesCbo.ValueMember = "Codigo";
                this.IngredientesCbo.DataSource = list;
                this.IngredientesCbo.Refresh();            
        }     
               

        private void PacienteBtn_Click(object sender, EventArgs e)
        {
            PacientesFrm frm = new PacientesFrm();
            frm.ShowDialog();
             
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult dgresult = MessageBox.Show("Desea salir del sistema?", "salir....", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(dgresult== System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void ListadosBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DietasBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<Dieta>.findAll();
        }

        private void PlatosBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<Plato>.findAll();
        }

        private void IngredientesBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<Ingrediente>.findAll();
        }

        private void ProfesionalesBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<Profesional>.findAll();
        }

        private void PlatosDietaBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<PlatoDieta>.findAll();
        }

        private void PlatosPacienteBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<PlatoPaciente>.findAll();
        }

        private void DietaPacienteBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<DietaPaciente>.findAll();
        }

        private void PacienteControlBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<PacienteControl>.findAll();
        }

        private void PlatoIngredienteBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<PlatoIngrediente>.findAll();
        }

        private void PacienteProfesionalBtn_Click(object sender, EventArgs e)
        {
            this.gridData.DataSource = ManagerDB<PacienteProfesional>.findAll();
        }
                
        private void SearchDniBtn_Click(object sender, EventArgs e)
        {
            Paciente p = new Paciente();
            p.findbykey(this.DniSearchTxt.Text);
            PacientesAMFrm fampac = new PacientesAMFrm();
            fampac.ShowPaciente(p);
        }
    }
}
