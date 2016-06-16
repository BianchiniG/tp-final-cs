namespace WinNutricion.Formularios
{
    partial class AltaPacProfFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dniPacBox = new System.Windows.Forms.TextBox();
            this.dniProfBox = new System.Windows.Forms.TextBox();
            this.labelDniPac = new System.Windows.Forms.Label();
            this.labelDniProf = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.errorDniProf = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDniPac = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniPac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dniPacBox);
            this.groupBox1.Controls.Add(this.dniProfBox);
            this.groupBox1.Controls.Add(this.labelDniPac);
            this.groupBox1.Controls.Add(this.labelDniProf);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dniPacBox
            // 
            this.dniPacBox.Location = new System.Drawing.Point(111, 42);
            this.dniPacBox.Name = "dniPacBox";
            this.dniPacBox.Size = new System.Drawing.Size(118, 20);
            this.dniPacBox.TabIndex = 3;
            // 
            // dniProfBox
            // 
            this.dniProfBox.Location = new System.Drawing.Point(111, 16);
            this.dniProfBox.Name = "dniProfBox";
            this.dniProfBox.Size = new System.Drawing.Size(118, 20);
            this.dniProfBox.TabIndex = 2;
            // 
            // labelDniPac
            // 
            this.labelDniPac.AutoSize = true;
            this.labelDniPac.Location = new System.Drawing.Point(20, 45);
            this.labelDniPac.Name = "labelDniPac";
            this.labelDniPac.Size = new System.Drawing.Size(71, 13);
            this.labelDniPac.TabIndex = 1;
            this.labelDniPac.Text = "DNI Paciente";
            // 
            // labelDniProf
            // 
            this.labelDniProf.AutoSize = true;
            this.labelDniProf.Location = new System.Drawing.Point(20, 19);
            this.labelDniProf.Name = "labelDniProf";
            this.labelDniProf.Size = new System.Drawing.Size(81, 13);
            this.labelDniProf.TabIndex = 0;
            this.labelDniProf.Text = "DNI Profesional";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(105, 91);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(186, 91);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // errorDniProf
            // 
            this.errorDniProf.ContainerControl = this;
            // 
            // errorDniPac
            // 
            this.errorDniPac.ContainerControl = this;
            // 
            // AltaPacProfFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 128);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 166);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 166);
            this.Name = "AltaPacProfFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Paciente a un Profesional";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDniPac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox dniPacBox;
        private System.Windows.Forms.TextBox dniProfBox;
        private System.Windows.Forms.Label labelDniPac;
        private System.Windows.Forms.Label labelDniProf;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ErrorProvider errorDniProf;
        private System.Windows.Forms.ErrorProvider errorDniPac;
    }
}