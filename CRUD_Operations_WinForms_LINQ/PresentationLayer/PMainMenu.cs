using System;
using System.Windows.Forms;

namespace CRUD_Operations.Presentation
{
    public partial class PMainMenu : Form
    {
        public PMainMenu()
        {
            InitializeComponent();
        }

        private void RegisterEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            PRegisterEmployees OpenRegisterEmployees = new PRegisterEmployees();

            Hide();
            OpenRegisterEmployees.Show();
        }

        private void SearchEmployeepMenuItem_Click(object sender, EventArgs e)
        {
            PSearchEmployees OpenSearchEmployees = new PSearchEmployees();

            Hide();
            OpenSearchEmployees.Show();
        }

        private void UpdateEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            PUpdateEmployees OpenUpdateEmployees = new PUpdateEmployees();

            Hide();
            OpenUpdateEmployees.Show();
        }

        private void DeleteEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            PDeleteEmployees OpenDeleteEmployees = new PDeleteEmployees();

            Hide();
            OpenDeleteEmployees.Show();
        }

        private void ExitApplicationMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir de la aplicación??", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            PAbout OpenAbout = new PAbout();

            Hide();
            OpenAbout.Show();
        }
    }
}