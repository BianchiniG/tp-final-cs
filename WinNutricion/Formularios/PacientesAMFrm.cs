using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibNutricion.db;

namespace WinNutricion
{
    public enum OperacionForm
    {
        frmConsulta =0, frmAlta=1,frmModificacion=2
    }

    public partial class PacientesAMFrm : Form
    {
        OperacionForm operacion = OperacionForm.frmConsulta; /**/
        Paciente p;
        public PacientesAMFrm()
        {
            InitializeComponent();
        }
        public void ShowPaciente(Paciente paciente)
        {
            this.operacion = OperacionForm.frmModificacion;
            this.Text = "Modificacion de informacion de paciente";
            p = paciente;
            this.ApellidoTxt.Text = p.Apellido;
            this.NombresTxt.Text = p.Nombre;
            this.DnitTxt.Text = p.Dni.ToString();
            this.DomicilioTxt.Text = p.Domicilio;
            this.TelefonoTxt.Text = p.Telefono;
            this.FechaNacDpk.Value = p.FechaNac;
            this.PesoTxt.Text = p.PesoInicial.ToString();
            this.TallaTxt.Text = p.Talla.ToString();
            this.ShowDialog();
        }
        public void NewPaciente()
        {
            this.Text = "Nuevo Paciente";
            this.operacion = OperacionForm.frmAlta;
            this.ShowDialog();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
         {
            if(this.operacion== OperacionForm.frmAlta)
            {
               p = new Paciente();
               p.Dni = Convert.ToInt32(this.DnitTxt.Text);               
            }
            p.Apellido = this.ApellidoTxt.Text;
            p.Nombre = this.NombresTxt.Text;
            p.Domicilio = this.DomicilioTxt.Text;
            p.Telefono = this.TelefonoTxt.Text;
            p.FechaNac = this.FechaNacDpk.Value;
            p.PesoInicial = float.Parse(this.PesoTxt.Text);
            p.Talla = float.Parse(this.TallaTxt.Text);  
            p.saveObj();
            this.Dispose();
        }
    }
}
