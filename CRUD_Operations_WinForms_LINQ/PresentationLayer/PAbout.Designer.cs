namespace CRUD_Operations.Presentation
{
    partial class PAbout
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
            this.LblDeveloper = new System.Windows.Forms.Label();
            this.LblNameIDE = new System.Windows.Forms.Label();
            this.LblMainLanguage = new System.Windows.Forms.Label();
            this.LblManagementBD = new System.Windows.Forms.Label();
            this.LblTradingMethodBD = new System.Windows.Forms.Label();
            this.LblDesignForms = new System.Windows.Forms.Label();
            this.LblNameProject = new System.Windows.Forms.Label();
            this.BtnExitAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDeveloper
            // 
            this.LblDeveloper.AutoSize = true;
            this.LblDeveloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeveloper.Location = new System.Drawing.Point(12, 70);
            this.LblDeveloper.Name = "LblDeveloper";
            this.LblDeveloper.Size = new System.Drawing.Size(230, 20);
            this.LblDeveloper.TabIndex = 0;
            this.LblDeveloper.Text = "Desarrollador: Luis F. Molina G.";
            // 
            // LblNameIDE
            // 
            this.LblNameIDE.AutoSize = true;
            this.LblNameIDE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameIDE.Location = new System.Drawing.Point(12, 98);
            this.LblNameIDE.Name = "LblNameIDE";
            this.LblNameIDE.Size = new System.Drawing.Size(391, 20);
            this.LblNameIDE.TabIndex = 1;
            this.LblNameIDE.Text = "Entorno De Desarrollo: Visual Studio 2015 Community";
            // 
            // LblMainLanguage
            // 
            this.LblMainLanguage.AutoSize = true;
            this.LblMainLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMainLanguage.Location = new System.Drawing.Point(12, 126);
            this.LblMainLanguage.Name = "LblMainLanguage";
            this.LblMainLanguage.Size = new System.Drawing.Size(166, 20);
            this.LblMainLanguage.TabIndex = 2;
            this.LblMainLanguage.Text = "Lenguaje Principal: C#";
            // 
            // LblManagementBD
            // 
            this.LblManagementBD.AutoSize = true;
            this.LblManagementBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManagementBD.Location = new System.Drawing.Point(12, 154);
            this.LblManagementBD.Name = "LblManagementBD";
            this.LblManagementBD.Size = new System.Drawing.Size(432, 20);
            this.LblManagementBD.TabIndex = 3;
            this.LblManagementBD.Text = "Motor De Base De Datos: SQL Server 2014 Express Edition";
            // 
            // LblTradingMethodBD
            // 
            this.LblTradingMethodBD.AutoSize = true;
            this.LblTradingMethodBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTradingMethodBD.Location = new System.Drawing.Point(12, 182);
            this.LblTradingMethodBD.Name = "LblTradingMethodBD";
            this.LblTradingMethodBD.Size = new System.Drawing.Size(341, 20);
            this.LblTradingMethodBD.TabIndex = 4;
            this.LblTradingMethodBD.Text = "Método De Negociación A BD: Consultas LINQ";
            // 
            // LblDesignForms
            // 
            this.LblDesignForms.AutoSize = true;
            this.LblDesignForms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesignForms.Location = new System.Drawing.Point(12, 210);
            this.LblDesignForms.Name = "LblDesignForms";
            this.LblDesignForms.Size = new System.Drawing.Size(180, 20);
            this.LblDesignForms.TabIndex = 5;
            this.LblDesignForms.Text = "Diseño: Windows Forms";
            // 
            // LblNameProject
            // 
            this.LblNameProject.AutoSize = true;
            this.LblNameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameProject.Location = new System.Drawing.Point(12, 19);
            this.LblNameProject.Name = "LblNameProject";
            this.LblNameProject.Size = new System.Drawing.Size(477, 24);
            this.LblNameProject.TabIndex = 6;
            this.LblNameProject.Text = "Operaciones CRUD En Windows Forms Con LINQ";
            // 
            // BtnExitAbout
            // 
            this.BtnExitAbout.Location = new System.Drawing.Point(214, 255);
            this.BtnExitAbout.Name = "BtnExitAbout";
            this.BtnExitAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnExitAbout.TabIndex = 0;
            this.BtnExitAbout.Text = "Salir";
            this.BtnExitAbout.UseVisualStyleBackColor = true;
            this.BtnExitAbout.Click += new System.EventHandler(this.BtnExitAbout_Click);
            // 
            // PAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 303);
            this.Controls.Add(this.BtnExitAbout);
            this.Controls.Add(this.LblNameProject);
            this.Controls.Add(this.LblDesignForms);
            this.Controls.Add(this.LblTradingMethodBD);
            this.Controls.Add(this.LblManagementBD);
            this.Controls.Add(this.LblMainLanguage);
            this.Controls.Add(this.LblNameIDE);
            this.Controls.Add(this.LblDeveloper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de";
            this.Load += new System.EventHandler(this.PAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExitAbout;
        private System.Windows.Forms.Label LblNameProject;
        private System.Windows.Forms.Label LblDeveloper;
        private System.Windows.Forms.Label LblNameIDE;
        private System.Windows.Forms.Label LblMainLanguage;
        private System.Windows.Forms.Label LblManagementBD;
        private System.Windows.Forms.Label LblTradingMethodBD;
        private System.Windows.Forms.Label LblDesignForms;     
    }
}