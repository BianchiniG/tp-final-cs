namespace WinNutricion.Formularios
{
    partial class AltaIngredienteUC
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.caja = new System.Windows.Forms.GroupBox();
            this.textBoxUnidMedida = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelUnidMedida = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.caja.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(580, 430);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 0;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(660, 430);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // caja
            // 
            this.caja.Controls.Add(this.textBoxUnidMedida);
            this.caja.Controls.Add(this.textBoxNombre);
            this.caja.Controls.Add(this.labelUnidMedida);
            this.caja.Controls.Add(this.labelNombre);
            this.caja.Location = new System.Drawing.Point(254, 36);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(255, 85);
            this.caja.TabIndex = 2;
            this.caja.TabStop = false;
            // 
            // textBoxUnidMedida
            // 
            this.textBoxUnidMedida.Location = new System.Drawing.Point(126, 52);
            this.textBoxUnidMedida.Name = "textBoxUnidMedida";
            this.textBoxUnidMedida.Size = new System.Drawing.Size(118, 20);
            this.textBoxUnidMedida.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(126, 17);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(118, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // labelUnidMedida
            // 
            this.labelUnidMedida.AutoSize = true;
            this.labelUnidMedida.Location = new System.Drawing.Point(10, 55);
            this.labelUnidMedida.Name = "labelUnidMedida";
            this.labelUnidMedida.Size = new System.Drawing.Size(94, 13);
            this.labelUnidMedida.TabIndex = 1;
            this.labelUnidMedida.Text = "Unidad de Medida";
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
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(312, 14);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(154, 17);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Alta de Ingredientes";
            // 
            // AltaIngredienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Name = "AltaIngredienteUC";
            this.Size = new System.Drawing.Size(747, 465);
            this.caja.ResumeLayout(false);
            this.caja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.GroupBox caja;
        private System.Windows.Forms.TextBox textBoxUnidMedida;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelUnidMedida;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label titulo;
    }
}
