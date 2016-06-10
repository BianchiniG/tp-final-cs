namespace WinNutricion
{
    partial class PrincipalFrm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PacientesBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.DietasBtn = new System.Windows.Forms.Button();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.PlatosBtn = new System.Windows.Forms.Button();
            this.IngredientesBtn = new System.Windows.Forms.Button();
            this.ProfesionalesBtn = new System.Windows.Forms.Button();
            this.PlatosDietaBtn = new System.Windows.Forms.Button();
            this.PlatosPacienteBtn = new System.Windows.Forms.Button();
            this.DietaPacienteBtn = new System.Windows.Forms.Button();
            this.PacienteControlBtn = new System.Windows.Forms.Button();
            this.PacienteProfesionalBtn = new System.Windows.Forms.Button();
            this.PlatoIngredienteBtn = new System.Windows.Forms.Button();
            this.SearchDniBtn = new System.Windows.Forms.Button();
            this.DniSearchTxt = new System.Windows.Forms.TextBox();
            this.IngredientesCbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // PacientesBtn
            // 
            this.PacientesBtn.Location = new System.Drawing.Point(26, 24);
            this.PacientesBtn.Name = "PacientesBtn";
            this.PacientesBtn.Size = new System.Drawing.Size(109, 30);
            this.PacientesBtn.TabIndex = 15;
            this.PacientesBtn.Text = "Pacientes";
            this.PacientesBtn.UseVisualStyleBackColor = true;
            this.PacientesBtn.Click += new System.EventHandler(this.PacienteBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(861, 24);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(109, 30);
            this.SalirBtn.TabIndex = 16;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // DietasBtn
            // 
            this.DietasBtn.Location = new System.Drawing.Point(26, 60);
            this.DietasBtn.Name = "DietasBtn";
            this.DietasBtn.Size = new System.Drawing.Size(109, 28);
            this.DietasBtn.TabIndex = 17;
            this.DietasBtn.Text = "Dietas";
            this.DietasBtn.UseVisualStyleBackColor = true;
            this.DietasBtn.Click += new System.EventHandler(this.DietasBtn_Click);
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(241, 44);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.Size = new System.Drawing.Size(504, 218);
            this.gridData.TabIndex = 18;
            // 
            // PlatosBtn
            // 
            this.PlatosBtn.Location = new System.Drawing.Point(26, 94);
            this.PlatosBtn.Name = "PlatosBtn";
            this.PlatosBtn.Size = new System.Drawing.Size(109, 28);
            this.PlatosBtn.TabIndex = 19;
            this.PlatosBtn.Text = "Platos";
            this.PlatosBtn.UseVisualStyleBackColor = true;
            this.PlatosBtn.Click += new System.EventHandler(this.PlatosBtn_Click);
            // 
            // IngredientesBtn
            // 
            this.IngredientesBtn.Location = new System.Drawing.Point(26, 128);
            this.IngredientesBtn.Name = "IngredientesBtn";
            this.IngredientesBtn.Size = new System.Drawing.Size(109, 28);
            this.IngredientesBtn.TabIndex = 20;
            this.IngredientesBtn.Text = "Ingredientes";
            this.IngredientesBtn.UseVisualStyleBackColor = true;
            this.IngredientesBtn.Click += new System.EventHandler(this.IngredientesBtn_Click);
            // 
            // ProfesionalesBtn
            // 
            this.ProfesionalesBtn.Location = new System.Drawing.Point(26, 162);
            this.ProfesionalesBtn.Name = "ProfesionalesBtn";
            this.ProfesionalesBtn.Size = new System.Drawing.Size(109, 28);
            this.ProfesionalesBtn.TabIndex = 21;
            this.ProfesionalesBtn.Text = "Profesionales";
            this.ProfesionalesBtn.UseVisualStyleBackColor = true;
            this.ProfesionalesBtn.Click += new System.EventHandler(this.ProfesionalesBtn_Click);
            // 
            // PlatosDietaBtn
            // 
            this.PlatosDietaBtn.Location = new System.Drawing.Point(26, 196);
            this.PlatosDietaBtn.Name = "PlatosDietaBtn";
            this.PlatosDietaBtn.Size = new System.Drawing.Size(109, 28);
            this.PlatosDietaBtn.TabIndex = 22;
            this.PlatosDietaBtn.Text = "PlatosDieta";
            this.PlatosDietaBtn.UseVisualStyleBackColor = true;
            this.PlatosDietaBtn.Click += new System.EventHandler(this.PlatosDietaBtn_Click);
            // 
            // PlatosPacienteBtn
            // 
            this.PlatosPacienteBtn.Location = new System.Drawing.Point(26, 230);
            this.PlatosPacienteBtn.Name = "PlatosPacienteBtn";
            this.PlatosPacienteBtn.Size = new System.Drawing.Size(109, 28);
            this.PlatosPacienteBtn.TabIndex = 23;
            this.PlatosPacienteBtn.Text = "PlatosPaciente";
            this.PlatosPacienteBtn.UseVisualStyleBackColor = true;
            this.PlatosPacienteBtn.Click += new System.EventHandler(this.PlatosPacienteBtn_Click);
            // 
            // DietaPacienteBtn
            // 
            this.DietaPacienteBtn.Location = new System.Drawing.Point(26, 264);
            this.DietaPacienteBtn.Name = "DietaPacienteBtn";
            this.DietaPacienteBtn.Size = new System.Drawing.Size(109, 28);
            this.DietaPacienteBtn.TabIndex = 24;
            this.DietaPacienteBtn.Text = "DietaPaciente";
            this.DietaPacienteBtn.UseVisualStyleBackColor = true;
            this.DietaPacienteBtn.Click += new System.EventHandler(this.DietaPacienteBtn_Click);
            // 
            // PacienteControlBtn
            // 
            this.PacienteControlBtn.Location = new System.Drawing.Point(26, 298);
            this.PacienteControlBtn.Name = "PacienteControlBtn";
            this.PacienteControlBtn.Size = new System.Drawing.Size(109, 28);
            this.PacienteControlBtn.TabIndex = 25;
            this.PacienteControlBtn.Text = "PacienteControl";
            this.PacienteControlBtn.UseVisualStyleBackColor = true;
            this.PacienteControlBtn.Click += new System.EventHandler(this.PacienteControlBtn_Click);
            // 
            // PacienteProfesionalBtn
            // 
            this.PacienteProfesionalBtn.Location = new System.Drawing.Point(26, 366);
            this.PacienteProfesionalBtn.Name = "PacienteProfesionalBtn";
            this.PacienteProfesionalBtn.Size = new System.Drawing.Size(109, 28);
            this.PacienteProfesionalBtn.TabIndex = 27;
            this.PacienteProfesionalBtn.Text = "PacienteProfesional";
            this.PacienteProfesionalBtn.UseVisualStyleBackColor = true;
            this.PacienteProfesionalBtn.Click += new System.EventHandler(this.PacienteProfesionalBtn_Click);
            // 
            // PlatoIngredienteBtn
            // 
            this.PlatoIngredienteBtn.Location = new System.Drawing.Point(26, 332);
            this.PlatoIngredienteBtn.Name = "PlatoIngredienteBtn";
            this.PlatoIngredienteBtn.Size = new System.Drawing.Size(109, 28);
            this.PlatoIngredienteBtn.TabIndex = 26;
            this.PlatoIngredienteBtn.Text = "PlatoIngrediente";
            this.PlatoIngredienteBtn.UseVisualStyleBackColor = true;
            this.PlatoIngredienteBtn.Click += new System.EventHandler(this.PlatoIngredienteBtn_Click);
            // 
            // SearchDniBtn
            // 
            this.SearchDniBtn.Location = new System.Drawing.Point(241, 332);
            this.SearchDniBtn.Name = "SearchDniBtn";
            this.SearchDniBtn.Size = new System.Drawing.Size(114, 32);
            this.SearchDniBtn.TabIndex = 29;
            this.SearchDniBtn.Text = "Buscar x Dni";
            this.SearchDniBtn.UseVisualStyleBackColor = true;
            this.SearchDniBtn.Click += new System.EventHandler(this.SearchDniBtn_Click);
            // 
            // DniSearchTxt
            // 
            this.DniSearchTxt.Location = new System.Drawing.Point(241, 298);
            this.DniSearchTxt.Name = "DniSearchTxt";
            this.DniSearchTxt.Size = new System.Drawing.Size(140, 20);
            this.DniSearchTxt.TabIndex = 30;
            // 
            // IngredientesCbo
            // 
            this.IngredientesCbo.DisplayMember = "Nombre";
            this.IngredientesCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IngredientesCbo.FormattingEnabled = true;
            this.IngredientesCbo.Location = new System.Drawing.Point(501, 303);
            this.IngredientesCbo.Name = "IngredientesCbo";
            this.IngredientesCbo.Size = new System.Drawing.Size(195, 21);
            this.IngredientesCbo.TabIndex = 31;
            this.IngredientesCbo.ValueMember = "Codigo";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(410, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Listado de Ingredientes:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(437, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "Control DropBox y configuracion de propiedades : ValuMember y DisplayMember";
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IngredientesCbo);
            this.Controls.Add(this.DniSearchTxt);
            this.Controls.Add(this.SearchDniBtn);
            this.Controls.Add(this.PacienteProfesionalBtn);
            this.Controls.Add(this.PlatoIngredienteBtn);
            this.Controls.Add(this.PacienteControlBtn);
            this.Controls.Add(this.DietaPacienteBtn);
            this.Controls.Add(this.PlatosPacienteBtn);
            this.Controls.Add(this.PlatosDietaBtn);
            this.Controls.Add(this.ProfesionalesBtn);
            this.Controls.Add(this.IngredientesBtn);
            this.Controls.Add(this.PlatosBtn);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.DietasBtn);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.PacientesBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.PrincipalFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PacientesBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.Button DietasBtn;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button PlatosBtn;
        private System.Windows.Forms.Button IngredientesBtn;
        private System.Windows.Forms.Button ProfesionalesBtn;
        private System.Windows.Forms.Button PlatosDietaBtn;
        private System.Windows.Forms.Button PlatosPacienteBtn;
        private System.Windows.Forms.Button DietaPacienteBtn;
        private System.Windows.Forms.Button PacienteControlBtn;
        private System.Windows.Forms.Button PacienteProfesionalBtn;
        private System.Windows.Forms.Button PlatoIngredienteBtn;
        private System.Windows.Forms.Button SearchDniBtn;
        private System.Windows.Forms.TextBox DniSearchTxt;
        private System.Windows.Forms.ComboBox IngredientesCbo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

