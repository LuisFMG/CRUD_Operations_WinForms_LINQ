using System;
using System.Windows.Forms;
using CRUD_Operations.Business;
using CRUD_Operations.Entities;

namespace CRUD_Operations.Presentation
{
    public partial class PUpdateEmployees : Form
    {
        public PUpdateEmployees()
        {
            InitializeComponent();
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            BEmployees BEmployees = new BEmployees();
            EEmployees EmployeeData = new EEmployees();

            if (BEmployees.SeekForUpdate(int.Parse(TxtIdEmployee.Text), EmployeeData))
            {
                TxtUsername.Text = EmployeeData.Username;
                TxtUserPassword.Text = EmployeeData.UserPassword;
                TxtEmployeeName.Text = EmployeeData.EmployeeName;
                TxtEmployeeFamilyName.Text = EmployeeData.EmployeeFamilyName;
                TxtEmail.Text = EmployeeData.Email;
            }
            else
            {
                MessageBox.Show("El empleado no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSubmitChanges_Click(object sender, EventArgs e)
        {
            BEmployees BEmployees = new BEmployees();
            EEmployees EmployeeData = new EEmployees();
            Validations Validate = new Validations();

            if (Validate.ValidateEmptyFields(TxtUsername.Text, TxtUserPassword.Text, TxtEmployeeName.Text, TxtEmployeeFamilyName.Text))
            {
                EmployeeData.IdEmployee = int.Parse(TxtIdEmployee.Text.ToUpper());
                EmployeeData.Username = TxtUsername.Text.ToUpper();
                EmployeeData.UserPassword = TxtUserPassword.Text;
                EmployeeData.EmployeeName = TxtEmployeeName.Text.ToUpper();
                EmployeeData.EmployeeFamilyName = TxtEmployeeFamilyName.Text.ToUpper();
                EmployeeData.Email = TxtEmail.Text.ToUpper();

                if (BEmployees.UpdateEmployee(EmployeeData))
                {
                    MessageBox.Show("Empleado actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TxtIdEmployee.Clear();
                    TxtUsername.Clear();
                    TxtUserPassword.Clear();
                    TxtEmployeeName.Clear();
                    TxtEmployeeFamilyName.Clear();
                    TxtEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Empleado no actualizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(Validate.SB.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnExitUpdateEmployee_Click(object sender, EventArgs e)
        {
            PMainMenu OpenMainMenu = new PMainMenu();

            Hide();
            OpenMainMenu.Show();
        }

        private void TxtIdEmployee_TextChanged(object sender, EventArgs e)
        {
            if (TxtIdEmployee.TextLength == 4)
            {
                BtnSearchEmployee.Enabled = true;
            }
            else
            {
                BtnSearchEmployee.Enabled = false;
            }
        }

        private void TxtIdEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.OnlyNumbers(e);
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.RemoveSpace(e);
        }

        private void TxtUserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.RemoveSpace(e);
        }

        private void TxtEmployeeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.OnlyLetters(e);
        }

        private void TxtEmployeeFamilyName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.OnlyLetters(e);
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.RemoveSpace(e);
        }
    }
}