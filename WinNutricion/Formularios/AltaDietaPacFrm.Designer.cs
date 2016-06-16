namespace WinNutricion.Formularios
{
    partial class AltaDietaPacFrm
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
            this.codDietaBox = new System.Windows.Forms.TextBox();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.labelCodDieta = new System.Windows.Forms.Label();
            this.labelDniPac = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.errorDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodDieta = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodDieta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codDietaBox);
            this.groupBox1.Controls.Add(this.dniBox);
            this.groupBox1.Controls.Add(this.labelCodDieta);
            this.groupBox1.Controls.Add(this.labelDniPac);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // codDietaBox
            // 
            this.codDietaBox.Location = new System.Drawing.Point(111, 42);
            this.codDietaBox.Name = "codDietaBox";
            this.codDietaBox.Size = new System.Drawing.Size(118, 20);
            this.codDietaBox.TabIndex = 3;
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(111, 16);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(118, 20);
            this.dniBox.TabIndex = 2;
            // 
            // labelCodDieta
            // 
            this.labelCodDieta.AutoSize = true;
            this.labelCodDieta.Location = new System.Drawing.Point(20, 45);
            this.labelCodDieta.Name = "labelCodDieta";
            this.labelCodDieta.Size = new System.Drawing.Size(83, 13);
            this.labelCodDieta.TabIndex = 1;
            this.labelCodDieta.Text = "Código de Dieta";
            // 
            // labelDniPac
            // 
            this.labelDniPac.AutoSize = true;
            this.labelDniPac.Location = new System.Drawing.Point(20, 19);
            this.labelDniPac.Name = "labelDniPac";
            this.labelDniPac.Size = new System.Drawing.Size(71, 13);
            this.labelDniPac.TabIndex = 0;
            this.labelDniPac.Text = "DNI Paciente";
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
            // errorDni
            // 
            this.errorDni.ContainerControl = this;
            // 
            // errorCodDieta
            // 
            this.errorCodDieta.ContainerControl = this;
            // 
            // AltaDietaPacFrm
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
            this.Name = "AltaDietaPacFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Dieta a un Paciente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodDieta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.TextBox codDietaBox;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label labelCodDieta;
        private System.Windows.Forms.Label labelDniPac;
        private System.Windows.Forms.ErrorProvider errorDni;
        private System.Windows.Forms.ErrorProvider errorCodDieta;
    }
}