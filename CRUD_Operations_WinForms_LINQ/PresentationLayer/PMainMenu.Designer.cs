namespace CRUD_Operations.Presentation
{
    partial class PMainMenu
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
            this.MenuStripCRUDOperations = new System.Windows.Forms.MenuStrip();
            this.EmployeesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchEmployeepMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplicationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripCRUDOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripCRUDOperations
            // 
            this.MenuStripCRUDOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeesMenu,
            this.HelpMenu});
            this.MenuStripCRUDOperations.Location = new System.Drawing.Point(0, 0);
            this.MenuStripCRUDOperations.Name = "MenuStripCRUDOperations";
            this.MenuStripCRUDOperations.Size = new System.Drawing.Size(364, 24);
            this.MenuStripCRUDOperations.TabIndex = 0;
            this.MenuStripCRUDOperations.Text = "menuStrip1";
            // 
            // EmployeesMenu
            // 
            this.EmployeesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterEmployeeMenuItem,
            this.SearchEmployeepMenuItem,
            this.UpdateEmployeeMenuItem,
            this.DeleteEmployeeMenuItem,
            this.ExitApplicationMenuItem});
            this.EmployeesMenu.Name = "EmployeesMenu";
            this.EmployeesMenu.Size = new System.Drawing.Size(77, 20);
            this.EmployeesMenu.Text = "Empleados";
            // 
            // RegisterEmployeeMenuItem
            // 
            this.RegisterEmployeeMenuItem.Name = "RegisterEmployeeMenuItem";
            this.RegisterEmployeeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RegisterEmployeeMenuItem.Text = "Insertar";
            this.RegisterEmployeeMenuItem.Click += new System.EventHandler(this.RegisterEmployeeMenuItem_Click);
            // 
            // SearchEmployeepMenuItem
            // 
            this.SearchEmployeepMenuItem.Name = "SearchEmployeepMenuItem";
            this.SearchEmployeepMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SearchEmployeepMenuItem.Text = "Buscar";
            this.SearchEmployeepMenuItem.Click += new System.EventHandler(this.SearchEmployeepMenuItem_Click);
            // 
            // UpdateEmployeeMenuItem
            // 
            this.UpdateEmployeeMenuItem.Name = "UpdateEmployeeMenuItem";
            this.UpdateEmployeeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.UpdateEmployeeMenuItem.Text = "Actualizar";
            this.UpdateEmployeeMenuItem.Click += new System.EventHandler(this.UpdateEmployeeMenuItem_Click);
            // 
            // DeleteEmployeeMenuItem
            // 
            this.DeleteEmployeeMenuItem.Name = "DeleteEmployeeMenuItem";
            this.DeleteEmployeeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteEmployeeMenuItem.Text = "Eliminar";
            this.DeleteEmployeeMenuItem.Click += new System.EventHandler(this.DeleteEmployeeMenuItem_Click);
            // 
            // ExitApplicationMenuItem
            // 
            this.ExitApplicationMenuItem.Name = "ExitApplicationMenuItem";
            this.ExitApplicationMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitApplicationMenuItem.Text = "Salir";
            this.ExitApplicationMenuItem.Click += new System.EventHandler(this.ExitApplicationMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(53, 20);
            this.HelpMenu.Text = "Ayuda";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AboutMenuItem.Text = "Acerca De";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // PMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.MenuStripCRUDOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStripCRUDOperations;
            this.Name = "PMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones CRUD En Windows Forms C#";
            this.MenuStripCRUDOperations.ResumeLayout(false);
            this.MenuStripCRUDOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripCRUDOperations;
        private System.Windows.Forms.ToolStripMenuItem EmployeesMenu;
        private System.Windows.Forms.ToolStripMenuItem RegisterEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchEmployeepMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitApplicationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
    }
}