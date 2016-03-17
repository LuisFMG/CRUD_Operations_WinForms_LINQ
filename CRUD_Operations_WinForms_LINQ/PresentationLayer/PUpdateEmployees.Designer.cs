namespace CRUD_Operations.Presentation
{
    partial class PUpdateEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIdEmployee = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtUserPassword = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtEmployeeFamilyName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnSearchEmployee = new System.Windows.Forms.Button();
            this.BtnSubmitChanges = new System.Windows.Forms.Button();
            this.BtnExitUpdateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo electrónico:";
            // 
            // TxtIdEmployee
            // 
            this.TxtIdEmployee.Location = new System.Drawing.Point(117, 28);
            this.TxtIdEmployee.MaxLength = 4;
            this.TxtIdEmployee.Name = "TxtIdEmployee";
            this.TxtIdEmployee.Size = new System.Drawing.Size(34, 20);
            this.TxtIdEmployee.TabIndex = 0;
            this.TxtIdEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtIdEmployee.TextChanged += new System.EventHandler(this.TxtIdEmployee_TextChanged);
            this.TxtIdEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdEmployee_KeyPress);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(117, 68);
            this.TxtUsername.MaxLength = 20;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(180, 20);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsername_KeyPress);
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.Location = new System.Drawing.Point(118, 108);
            this.TxtUserPassword.MaxLength = 20;
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.Size = new System.Drawing.Size(180, 20);
            this.TxtUserPassword.TabIndex = 2;
            this.TxtUserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserPassword_KeyPress);
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(118, 148);
            this.TxtEmployeeName.MaxLength = 20;
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(180, 20);
            this.TxtEmployeeName.TabIndex = 3;
            this.TxtEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmployeeName_KeyPress);
            // 
            // TxtEmployeeFamilyName
            // 
            this.TxtEmployeeFamilyName.Location = new System.Drawing.Point(118, 188);
            this.TxtEmployeeFamilyName.MaxLength = 40;
            this.TxtEmployeeFamilyName.Name = "TxtEmployeeFamilyName";
            this.TxtEmployeeFamilyName.Size = new System.Drawing.Size(220, 20);
            this.TxtEmployeeFamilyName.TabIndex = 4;
            this.TxtEmployeeFamilyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmployeeFamilyName_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(118, 228);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(260, 20);
            this.TxtEmail.TabIndex = 5;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // BtnSearchEmployee
            // 
            this.BtnSearchEmployee.Enabled = false;
            this.BtnSearchEmployee.Location = new System.Drawing.Point(157, 27);
            this.BtnSearchEmployee.Name = "BtnSearchEmployee";
            this.BtnSearchEmployee.Size = new System.Drawing.Size(75, 22);
            this.BtnSearchEmployee.TabIndex = 6;
            this.BtnSearchEmployee.Text = "Buscar";
            this.BtnSearchEmployee.UseVisualStyleBackColor = true;
            this.BtnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // BtnSubmitChanges
            // 
            this.BtnSubmitChanges.Location = new System.Drawing.Point(145, 291);
            this.BtnSubmitChanges.Name = "BtnSubmitChanges";
            this.BtnSubmitChanges.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmitChanges.TabIndex = 7;
            this.BtnSubmitChanges.Text = "Aplicar";
            this.BtnSubmitChanges.UseVisualStyleBackColor = true;
            this.BtnSubmitChanges.Click += new System.EventHandler(this.BtnSubmitChanges_Click);
            // 
            // BtnExitUpdateEmployee
            // 
            this.BtnExitUpdateEmployee.Location = new System.Drawing.Point(264, 291);
            this.BtnExitUpdateEmployee.Name = "BtnExitUpdateEmployee";
            this.BtnExitUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.BtnExitUpdateEmployee.TabIndex = 8;
            this.BtnExitUpdateEmployee.Text = "Salir";
            this.BtnExitUpdateEmployee.UseVisualStyleBackColor = true;
            this.BtnExitUpdateEmployee.Click += new System.EventHandler(this.BtnExitUpdateEmployee_Click);
            // 
            // PUpdateEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.BtnExitUpdateEmployee);
            this.Controls.Add(this.BtnSubmitChanges);
            this.Controls.Add(this.BtnSearchEmployee);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtEmployeeFamilyName);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtUserPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtIdEmployee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PUpdateEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdEmployee;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtUserPassword;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeFamilyName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnSearchEmployee;
        private System.Windows.Forms.Button BtnSubmitChanges;
        private System.Windows.Forms.Button BtnExitUpdateEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;      
    }
}