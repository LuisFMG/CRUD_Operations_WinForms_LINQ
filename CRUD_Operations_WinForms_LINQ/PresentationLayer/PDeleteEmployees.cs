using System;
using System.Windows.Forms;
using CRUD_Operations.Business;

namespace CRUD_Operations.Presentation
{
    public partial class PDeleteEmployees : Form
    {
        public PDeleteEmployees()
        {
            InitializeComponent();
        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            BEmployees BEmployees = new BEmployees();

            if (BEmployees.DeleteEmployee(int.Parse(TxtIdEmployee.Text)) > 0)
            {
                MessageBox.Show("Empleado eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIdEmployee.Clear();
            }
            else
            {
                MessageBox.Show("El empleado no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExitDeleteEmployees_Click(object sender, EventArgs e)
        {
            PMainMenu OpenMainMenu = new PMainMenu();

            Hide();
            OpenMainMenu.Show();
        }

        private void TxtIdEmployee_TextChanged(object sender, EventArgs e)
        {
            if (TxtIdEmployee.TextLength == 4)
            {
                BtnDeleteEmployee.Enabled = true;
            }
            else
            {
                BtnDeleteEmployee.Enabled = false;
            }
        }

        private void TxtIdEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.OnlyNumbers(e);
        }
    }
}