namespace CRUD_Operations.Presentation
{
    partial class PDeleteEmployees
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
            this.TxtIdEmployee = new System.Windows.Forms.TextBox();
            this.BtnDeleteEmployee = new System.Windows.Forms.Button();
            this.BtnExitDeleteEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Id Empleado:";
            // 
            // TxtIdEmployee
            // 
            this.TxtIdEmployee.Location = new System.Drawing.Point(158, 28);
            this.TxtIdEmployee.MaxLength = 4;
            this.TxtIdEmployee.Name = "TxtIdEmployee";
            this.TxtIdEmployee.Size = new System.Drawing.Size(34, 20);
            this.TxtIdEmployee.TabIndex = 0;
            this.TxtIdEmployee.TextChanged += new System.EventHandler(this.TxtIdEmployee_TextChanged);
            this.TxtIdEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIdEmployee_KeyPress);
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.Enabled = false;
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(39, 73);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(76, 24);
            this.BtnDeleteEmployee.TabIndex = 1;
            this.BtnDeleteEmployee.Text = "Eliminar";
            this.BtnDeleteEmployee.UseVisualStyleBackColor = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // BtnExitDeleteEmployees
            // 
            this.BtnExitDeleteEmployees.Location = new System.Drawing.Point(125, 74);
            this.BtnExitDeleteEmployees.Name = "BtnExitDeleteEmployees";
            this.BtnExitDeleteEmployees.Size = new System.Drawing.Size(75, 23);
            this.BtnExitDeleteEmployees.TabIndex = 2;
            this.BtnExitDeleteEmployees.Text = "Salir";
            this.BtnExitDeleteEmployees.UseVisualStyleBackColor = true;
            this.BtnExitDeleteEmployees.Click += new System.EventHandler(this.BtnExitDeleteEmployees_Click);
            // 
            // PDeleteEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 129);
            this.Controls.Add(this.BtnExitDeleteEmployees);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.TxtIdEmployee);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PDeleteEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.TextBox TxtIdEmployee;
        private System.Windows.Forms.Button BtnDeleteEmployee;
        private System.Windows.Forms.Button BtnExitDeleteEmployees;
        private System.Windows.Forms.Label label1;
    }
}