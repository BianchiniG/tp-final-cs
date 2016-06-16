namespace WinNutricion.Formularios
{
    partial class AltaPacienteUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.GroupBox();
            this.textBoxTalla = new System.Windows.Forms.TextBox();
            this.textBoxPesoIni = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelTalla = new System.Windows.Forms.Label();
            this.labelPesoIni = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelDomicilio = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDomicilio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPesoIni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTalla = new System.Windows.Forms.ErrorProvider(this.components);
            this.caja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPesoIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTalla)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.CausesValidation = false;
            this.botonCancelar.Location = new System.Drawing.Point(660, 430);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 0;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(580, 430);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(315, 14);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(135, 17);
            this.titulo.TabIndex = 2;
            this.titulo.Text = "Alta de Pacientes";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // caja
            // 
            this.caja.Controls.Add(this.textBoxTalla);
            this.caja.Controls.Add(this.textBoxPesoIni);
            this.caja.Controls.Add(this.textBoxTelefono);
            this.caja.Controls.Add(this.dateTimePicker);
            this.caja.Controls.Add(this.textBoxDni);
            this.caja.Controls.Add(this.textBoxDomicilio);
            this.caja.Controls.Add(this.textBoxApellido);
            this.caja.Controls.Add(this.textBoxNombre);
            this.caja.Controls.Add(this.labelTalla);
            this.caja.Controls.Add(this.labelPesoIni);
            this.caja.Controls.Add(this.labelTelefono);
            this.caja.Controls.Add(this.labelFechaNac);
            this.caja.Controls.Add(this.labelDni);
            this.caja.Controls.Add(this.labelDomicilio);
            this.caja.Controls.Add(this.labelApellido);
            this.caja.Controls.Add(this.labelNombre);
            this.caja.Location = new System.Drawing.Point(249, 36);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(265, 295);
            this.caja.TabIndex = 3;
            this.caja.TabStop = false;
            // 
            // textBoxTalla
            // 
            this.textBoxTalla.Location = new System.Drawing.Point(126, 262);
            this.textBoxTalla.Name = "textBoxTalla";
            this.textBoxTalla.Size = new System.Drawing.Size(118, 20);
            this.textBoxTalla.TabIndex = 15;
            // 
            // textBoxPesoIni
            // 
            this.textBoxPesoIni.Location = new System.Drawing.Point(126, 227);
            this.textBoxPesoIni.Name = "textBoxPesoIni";
            this.textBoxPesoIni.Size = new System.Drawing.Size(118, 20);
            this.textBoxPesoIni.TabIndex = 14;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(126, 192);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(118, 20);
            this.textBoxTelefono.TabIndex = 13;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(126, 157);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(126, 122);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(118, 20);
            this.textBoxDni.TabIndex = 11;
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Location = new System.Drawing.Point(126, 87);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(118, 20);
            this.textBoxDomicilio.TabIndex = 10;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(126, 52);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(118, 20);
            this.textBoxApellido.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(126, 17);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(118, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // labelTalla
            // 
            this.labelTalla.AutoSize = true;
            this.labelTalla.Location = new System.Drawing.Point(10, 265);
            this.labelTalla.Name = "labelTalla";
            this.labelTalla.Size = new System.Drawing.Size(54, 13);
            this.labelTalla.TabIndex = 7;
            this.labelTalla.Text = "Talla (Cm)";
            // 
            // labelPesoIni
            // 
            this.labelPesoIni.AutoSize = true;
            this.labelPesoIni.Location = new System.Drawing.Point(10, 230);
            this.labelPesoIni.Name = "labelPesoIni";
            this.labelPesoIni.Size = new System.Drawing.Size(83, 13);
            this.labelPesoIni.TabIndex = 6;
            this.labelPesoIni.Text = "Peso Inicial (Kg)";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(10, 195);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.Location = new System.Drawing.Point(10, 160);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(108, 13);
            this.labelFechaNac.TabIndex = 4;
            this.labelFechaNac.Text = "Fecha de Nacimiento";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(10, 125);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 3;
            this.labelDni.Text = "DNI";
            // 
            // labelDomicilio
            // 
            this.labelDomicilio.AutoSize = true;
            this.labelDomicilio.Location = new System.Drawing.Point(10, 90);
            this.labelDomicilio.Name = "labelDomicilio";
            this.labelDomicilio.Size = new System.Drawing.Size(49, 13);
            this.labelDomicilio.TabIndex = 2;
            this.labelDomicilio.Text = "Domicilio";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(10, 55);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(10, 20);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderApellido
            // 
            this.errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderDomicilio
            // 
            this.errorProviderDomicilio.ContainerControl = this;
            // 
            // errorProviderDni
            // 
            this.errorProviderDni.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            // 
            // errorProviderPesoIni
            // 
            this.errorProviderPesoIni.ContainerControl = this;
            // 
            // errorProviderTalla
            // 
            this.errorProviderTalla.ContainerControl = this;
            // 
            // AltaPacienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.caja);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.botonCancelar);
            this.Name = "AltaPacienteUC";
            this.Size = new System.Drawing.Size(747, 465);
            this.caja.ResumeLayout(false);
            this.caja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPesoIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox caja;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTalla;
        private System.Windows.Forms.Label labelPesoIni;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelDomicilio;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxTalla;
        private System.Windows.Forms.TextBox textBoxPesoIni;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDomicilio;
        private System.Windows.Forms.ErrorProvider errorProviderDni;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderPesoIni;
        private System.Windows.Forms.ErrorProvider errorProviderTalla;
    }
}
