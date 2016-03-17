using System;
using System.Windows.Forms;
using CRUD_Operations.Business;

namespace CRUD_Operations.Presentation
{
    public partial class PSearchEmployees : Form
    {
        public PSearchEmployees()
        {
            InitializeComponent();
        }

        private void PSearchEmployees_Load(object sender, EventArgs e)
        {
            BEmployees BEmployees = new BEmployees();

            if (BEmployees.SearchEmployee(int.Parse(TxtIdEmployee.Text), DgvEmployees) == true)
            {
                DgvEmployees.Columns[0].DataPropertyName = "Id_User";
                DgvEmployees.Columns[1].DataPropertyName = "Username";
                DgvEmployees.Columns[2].DataPropertyName = "User_Password";
                DgvEmployees.Columns[3].DataPropertyName = "Date_Of_Hire";
                DgvEmployees.Columns[4].DataPropertyName = "Employee_Name";
                DgvEmployees.Columns[5].DataPropertyName = "Employee_Family_Name";
                DgvEmployees.Columns[6].DataPropertyName = "Date_Of_Birth";
                DgvEmployees.Columns[7].DataPropertyName = "Age";
                DgvEmployees.Columns[8].DataPropertyName = "Email";
            }
            else
            {
                MessageBox.Show("Carga de empleados fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExitSearchEmployees_Click(object sender, EventArgs e)
        {
            PMainMenu OpenMainMenu = new PMainMenu();

            Close();
            OpenMainMenu.Show();
        }

        private void TxtIdEmployee_TextChanged_1(object sender, EventArgs e)
        {
            int IdEmployee = 0;
            BEmployees BEmployees = new BEmployees();

            if (TxtIdEmployee.TextLength == 4)
            {
                BEmployees.SearchEmployee(int.Parse(TxtIdEmployee.Text), DgvEmployees);
            }
            else
            {
                BEmployees.SearchEmployee(IdEmployee, DgvEmployees);
            }
        }
    }
}