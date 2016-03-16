namespace CRUD_Operations.Presentation
{
    partial class PRegisterEmployees
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
            this.PbPhotoEmployee = new System.Windows.Forms.PictureBox();
            this.CbDevicesWebCam = new System.Windows.Forms.ComboBox();
            this.BtnExitRegisterEmployee = new System.Windows.Forms.Button();
            this.BtnRegisterEmployee = new System.Windows.Forms.Button();
            this.BtnRestarWebCam = new System.Windows.Forms.Button();
            this.BtnCapturePhoto = new System.Windows.Forms.Button();
            this.TxtIdEmployee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUserPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmployeeFamilyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDateOfHire = new System.Windows.Forms.Label();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VspPhotoEmployee = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.PbPhotoEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // PbPhotoEmployee
            // 
            this.PbPhotoEmployee.Location = new System.Drawing.Point(417, 116);
            this.PbPhotoEmployee.Name = "PbPhotoEmployee";
            this.PbPhotoEmployee.Size = new System.Drawing.Size(136, 176);
            this.PbPhotoEmployee.TabIndex = 39;
            this.PbPhotoEmployee.TabStop = false;
            this.PbPhotoEmployee.Visible = false;
            // 
            // CbDevicesWebCam
            // 
            this.CbDevicesWebCam.FormattingEnabled = true;
            this.CbDevicesWebCam.Location = new System.Drawing.Point(417, 59);
            this.CbDevicesWebCam.Name = "CbDevicesWebCam";
            this.CbDevicesWebCam.Size = new System.Drawing.Size(136, 21);
            this.CbDevicesWebCam.TabIndex = 34;
            // 
            // BtnExitRegisterEmployee
            // 
            this.BtnExitRegisterEmployee.Location = new System.Drawing.Point(313, 388);
            this.BtnExitRegisterEmployee.Name = "BtnExitRegisterEmployee";
            this.BtnExitRegisterEmployee.Size = new System.Drawing.Size(74, 24);
            this.BtnExitRegisterEmployee.TabIndex = 38;
            this.BtnExitRegisterEmployee.Text = "Salir";
            this.BtnExitRegisterEmployee.UseVisualStyleBackColor = true;
            this.BtnExitRegisterEmployee.Click += new System.EventHandler(this.BtnExitRegisterEmployee_Click);
            // 
            // BtnRegisterEmployee
            // 
            this.BtnRegisterEmployee.Location = new System.Drawing.Point(197, 388);
            this.BtnRegisterEmployee.Name = "BtnRegisterEmployee";
            this.BtnRegisterEmployee.Size = new System.Drawing.Size(74, 24);
            this.BtnRegisterEmployee.TabIndex = 37;
            this.BtnRegisterEmployee.Text = "Registrar";
            this.BtnRegisterEmployee.UseVisualStyleBackColor = true;
            this.BtnRegisterEmployee.Click += new System.EventHandler(this.BtnRegisterEmployee_Click);
            // 
            // BtnRestarWebCam
            // 
            this.BtnRestarWebCam.Location = new System.Drawing.Point(495, 86);
            this.BtnRestarWebCam.Name = "BtnRestarWebCam";
            this.BtnRestarWebCam.Size = new System.Drawing.Size(58, 24);
            this.BtnRestarWebCam.TabIndex = 36;
            this.BtnRestarWebCam.Text = "Reiniciar";
            this.BtnRestarWebCam.UseVisualStyleBackColor = true;
            this.BtnRestarWebCam.Click += new System.EventHandler(this.BtnRestarWebCam_Click);
            // 
            // BtnCapturePhoto
            // 
            this.BtnCapturePhoto.Location = new System.Drawing.Point(417, 86);
            this.BtnCapturePhoto.Name = "BtnCapturePhoto";
            this.BtnCapturePhoto.Size = new System.Drawing.Size(58, 24);
            this.BtnCapturePhoto.TabIndex = 35;
            this.BtnCapturePhoto.Text = "Capturar";
            this.BtnCapturePhoto.UseVisualStyleBackColor = true;
            this.BtnCapturePhoto.Click += new System.EventHandler(this.BtnCapturePhoto_Click);
            // 
            // TxtIdEmployee
            // 
            this.TxtIdEmployee.Location = new System.Drawing.Point(127, 60);
            this.TxtIdEmployee.MaxLength = 4;
            this.TxtIdEmployee.Name = "TxtIdEmployee";
            this.TxtIdEmployee.ReadOnly = true;
            this.TxtIdEmployee.Size = new System.Drawing.Size(34, 20);
            this.TxtIdEmployee.TabIndex = 26;
            this.TxtIdEmployee.Text = "0";
            this.TxtIdEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "No. Empleado:";
            // 
            // TxtUserPassword
            // 
            this.TxtUserPassword.Location = new System.Drawing.Point(127, 142);
            this.TxtUserPassword.MaxLength = 20;
            this.TxtUserPassword.Name = "TxtUserPassword";
            this.TxtUserPassword.PasswordChar = '●';
            this.TxtUserPassword.Size = new System.Drawing.Size(180, 20);
            this.TxtUserPassword.TabIndex = 28;
            this.TxtUserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserPassword_KeyPress);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(127, 100);
            this.TxtUsername.MaxLength = 20;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(180, 20);
            this.TxtUsername.TabIndex = 27;
            this.TxtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsername_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Usuario:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(127, 328);
            this.TxtEmail.MaxLength = 100;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(260, 20);
            this.TxtEmail.TabIndex = 33;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Correo electrónico:";
            // 
            // TxtAge
            // 
            this.TxtAge.Location = new System.Drawing.Point(127, 292);
            this.TxtAge.MaxLength = 2;
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.ReadOnly = true;
            this.TxtAge.Size = new System.Drawing.Size(28, 20);
            this.TxtAge.TabIndex = 32;
            this.TxtAge.Text = "0";
            this.TxtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Edad:";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Location = new System.Drawing.Point(127, 256);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(220, 20);
            this.DtpDateOfBirth.TabIndex = 31;
            this.DtpDateOfBirth.ValueChanged += new System.EventHandler(this.DtpDateOfBirth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // TxtEmployeeFamilyName
            // 
            this.TxtEmployeeFamilyName.Location = new System.Drawing.Point(127, 220);
            this.TxtEmployeeFamilyName.MaxLength = 40;
            this.TxtEmployeeFamilyName.Name = "TxtEmployeeFamilyName";
            this.TxtEmployeeFamilyName.Size = new System.Drawing.Size(220, 20);
            this.TxtEmployeeFamilyName.TabIndex = 30;
            this.TxtEmployeeFamilyName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmployeeFamilyName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellidos:";
            // 
            // LblDateOfHire
            // 
            this.LblDateOfHire.AutoSize = true;
            this.LblDateOfHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfHire.Location = new System.Drawing.Point(237, 15);
            this.LblDateOfHire.Name = "LblDateOfHire";
            this.LblDateOfHire.Size = new System.Drawing.Size(110, 20);
            this.LblDateOfHire.TabIndex = 18;
            this.LblDateOfHire.Text = "Date Of Hire";
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(127, 184);
            this.TxtEmployeeName.MaxLength = 20;
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(180, 20);
            this.TxtEmployeeName.TabIndex = 29;
            this.TxtEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmployeeName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombre:";
            // 
            // VspPhotoEmployee
            // 
            this.VspPhotoEmployee.Location = new System.Drawing.Point(417, 116);
            this.VspPhotoEmployee.Name = "VspPhotoEmployee";
            this.VspPhotoEmployee.Size = new System.Drawing.Size(136, 176);
            this.VspPhotoEmployee.TabIndex = 40;
            this.VspPhotoEmployee.Text = "videoSourcePlayer1";
            this.VspPhotoEmployee.VideoSource = null;
            // 
            // PRegisterEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 443);
            this.Controls.Add(this.PbPhotoEmployee);
            this.Controls.Add(this.VspPhotoEmployee);
            this.Controls.Add(this.CbDevicesWebCam);
            this.Controls.Add(this.BtnExitRegisterEmployee);
            this.Controls.Add(this.BtnRegisterEmployee);
            this.Controls.Add(this.BtnRestarWebCam);
            this.Controls.Add(this.BtnCapturePhoto);
            this.Controls.Add(this.TxtIdEmployee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtUserPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtEmployeeFamilyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblDateOfHire);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PRegisterEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Empleado";
            this.Load += new System.EventHandler(this.PRegisterEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbPhotoEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIdEmployee;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtUserPassword;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeFamilyName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtEmail;           
        private System.Windows.Forms.Button BtnRegisterEmployee;
        private System.Windows.Forms.Button BtnRestarWebCam;
        private System.Windows.Forms.Button BtnCapturePhoto;
        private System.Windows.Forms.Button BtnExitRegisterEmployee;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.ComboBox CbDevicesWebCam;
        private System.Windows.Forms.PictureBox PbPhotoEmployee;
        private AForge.Controls.VideoSourcePlayer VspPhotoEmployee;
        private System.Windows.Forms.Label LblDateOfHire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}