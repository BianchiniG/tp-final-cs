namespace WinNutricion.Formularios
{
    partial class AltaIngrFrm
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
            this.unidadMedidaBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.unidadMedidaLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.nombreError = new System.Windows.Forms.ErrorProvider(this.components);
            this.unidadMedError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unidadMedidaBox);
            this.groupBox1.Controls.Add(this.nombreBox);
            this.groupBox1.Controls.Add(this.unidadMedidaLabel);
            this.groupBox1.Controls.Add(this.nombreLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // unidadMedidaBox
            // 
            this.unidadMedidaBox.Location = new System.Drawing.Point(120, 42);
            this.unidadMedidaBox.Name = "unidadMedidaBox";
            this.unidadMedidaBox.Size = new System.Drawing.Size(113, 20);
            this.unidadMedidaBox.TabIndex = 3;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(111, 16);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(122, 20);
            this.nombreBox.TabIndex = 2;
            // 
            // unidadMedidaLabel
            // 
            this.unidadMedidaLabel.AutoSize = true;
            this.unidadMedidaLabel.Location = new System.Drawing.Point(20, 45);
            this.unidadMedidaLabel.Name = "unidadMedidaLabel";
            this.unidadMedidaLabel.Size = new System.Drawing.Size(94, 13);
            this.unidadMedidaLabel.TabIndex = 1;
            this.unidadMedidaLabel.Text = "Unidad de Medida";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(20, 19);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(105, 96);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(186, 96);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // nombreError
            // 
            this.nombreError.ContainerControl = this;
            // 
            // unidadMedError
            // 
            this.unidadMedError.ContainerControl = this;
            // 
            // AltaIngrFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(289, 134);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 172);
            this.Name = "AltaIngrFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Ingrediente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nombreError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadMedError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox unidadMedidaBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label unidadMedidaLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ErrorProvider nombreError;
        private System.Windows.Forms.ErrorProvider unidadMedError;
    }
}