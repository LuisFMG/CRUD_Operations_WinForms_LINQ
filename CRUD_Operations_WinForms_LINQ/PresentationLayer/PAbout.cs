using System;
using System.Drawing;
using System.Windows.Forms;

namespace CRUD_Operations.Presentation
{
    public partial class PAbout : Form
    {
        public PAbout()
        {
            InitializeComponent();
        }

        private void PAbout_Load(object sender, EventArgs e)
        {
            Rectangle R = this.ClientRectangle;
            int C = R.Width / 2;

            LblNameProject.Location = new Point(C - LblNameProject.Width / 2, LblNameProject.Location.Y);
            LblDeveloper.Location = new Point(C - LblDeveloper.Width / 2, LblDeveloper.Location.Y);
            LblNameIDE.Location = new Point(C - LblNameIDE.Width / 2, LblNameIDE.Location.Y);
            LblMainLanguage.Location = new Point(C - LblMainLanguage.Width / 2, LblMainLanguage.Location.Y);
            LblManagementBD.Location = new Point(C - LblManagementBD.Width / 2, LblManagementBD.Location.Y);
            LblTradingMethodBD.Location = new Point(C - LblTradingMethodBD.Width / 2, LblTradingMethodBD.Location.Y);
            LblDesignForms.Location = new Point(C - LblDesignForms.Width / 2, LblDesignForms.Location.Y);
        }

        private void BtnExitAbout_Click(object sender, EventArgs e)
        {
            PMainMenu OpenMainMenu = new PMainMenu();

            Hide();
            OpenMainMenu.Show();
        }
    }
}