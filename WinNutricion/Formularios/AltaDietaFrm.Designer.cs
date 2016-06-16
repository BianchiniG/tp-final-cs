namespace WinNutricion.Formularios
{
    partial class AltaDietaFrm
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.RichTextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.autorBox = new System.Windows.Forms.TextBox();
            this.autorLabel = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.autorError = new System.Windows.Forms.ErrorProvider(this.components);
            this.nombreError = new System.Windows.Forms.ErrorProvider(this.components);
            this.descripcionError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nombreLabel);
            this.groupBox1.Controls.Add(this.descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(this.nombreBox);
            this.groupBox1.Controls.Add(this.autorBox);
            this.groupBox1.Controls.Add(this.autorLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(20, 45);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(44, 13);
            this.nombreLabel.TabIndex = 5;
            this.nombreLabel.Text = "Nombre";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(20, 71);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(63, 13);
            this.descripcionLabel.TabIndex = 4;
            this.descripcionLabel.Text = "Descripción";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(111, 68);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(122, 152);
            this.descripcionTextBox.TabIndex = 3;
            this.descripcionTextBox.Text = "";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(111, 42);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(122, 20);
            this.nombreBox.TabIndex = 2;
            // 
            // autorBox
            // 
            this.autorBox.Location = new System.Drawing.Point(111, 16);
            this.autorBox.Name = "autorBox";
            this.autorBox.Size = new System.Drawing.Size(122, 20);
            this.autorBox.TabIndex = 1;
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Location = new System.Drawing.Point(20, 19);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(32, 13);
            this.autorLabel.TabIndex = 0;
            this.autorLabel.Text = "Autor";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(105, 248);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.CausesValidation = false;
            this.botonCancelar.Location = new System.Drawing.Point(186, 248);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 2;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // autorError
            // 
            this.autorError.ContainerControl = this;
            // 
            // nombreError
            // 
            this.nombreError.ContainerControl = this;
            // 
            // descripcionError
            // 
            this.descripcionError.ContainerControl = this;
            // 
            // AltaDietaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 286);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 324);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 324);
            this.Name = "AltaDietaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Dieta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autorError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descripcionError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.TextBox autorBox;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.RichTextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ErrorProvider autorError;
        private System.Windows.Forms.ErrorProvider nombreError;
        private System.Windows.Forms.ErrorProvider descripcionError;
    }
}