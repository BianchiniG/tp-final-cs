namespace WinNutricion.Formularios
{
    partial class BuscaDniPacUC
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
            this.titulo = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDni = new System.Windows.Forms.Label();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.caja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(275, 14);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(186, 17);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Buscar Paciente por DNI";
            // 
            // caja
            // 
            this.caja.Controls.Add(this.dniBox);
            this.caja.Controls.Add(this.labelDni);
            this.caja.Controls.Add(this.botonCancelar);
            this.caja.Controls.Add(this.botonBuscar);
            this.caja.Location = new System.Drawing.Point(235, 35);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(276, 83);
            this.caja.TabIndex = 1;
            this.caja.TabStop = false;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(14, 50);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 0;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(187, 50);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(20, 19);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(68, 13);
            this.labelDni.TabIndex = 3;
            this.labelDni.Text = "Dni Paciente";
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(111, 16);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(118, 20);
            this.dniBox.TabIndex = 4;
            // 
            // BuscaDniPacUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.titulo);
            this.Name = "BuscaDniPacUC";
            this.Size = new System.Drawing.Size(747, 465);
            this.caja.ResumeLayout(false);
            this.caja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox caja;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button botonBuscar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.Label labelDni;
    }
}
