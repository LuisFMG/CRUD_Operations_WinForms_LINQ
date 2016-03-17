using System.Text;
using System.Windows.Forms;
using CRUD_Operations.Entities;

namespace CRUD_Operations.Presentation
{
    public class Validations
    {
        public readonly StringBuilder SB = new StringBuilder();

        public static void OnlyLetters(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void OnlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void RemoveSpace(KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool ValidateEmptyFields(EEmployees EmployeeData)
        {
            SB.Clear();

            if (string.IsNullOrEmpty(EmployeeData.Username)) SB.Append("El campo 'Usuario' no puede estar vacío\n");
            if (string.IsNullOrEmpty(EmployeeData.UserPassword)) SB.Append("El campo 'Contraseña' no puede estar vacío\n");
            if (string.IsNullOrEmpty(EmployeeData.EmployeeName)) SB.Append("El campo 'Nombre' no puede estar vacío\n");
            if (string.IsNullOrEmpty(EmployeeData.EmployeeFamilyName)) SB.Append("El campo 'Apellidos' no puede estar vacío\n");
            if (EmployeeData.Age == 0) SB.Append("El campo 'Edad' no puede estar vacío");

        return SB.Length == 0;
        }

        public bool ValidateEmptyFields(string Username, string UserPassword, string EmployeeName, string EmployeeFamilyName)
        {
            SB.Clear();

            if (string.IsNullOrEmpty(Username)) SB.Append("El campo 'Usuario' no puede estar vacío\n");
            if (string.IsNullOrEmpty(UserPassword)) SB.Append("El campo 'Contraseña' no puede estar vacío\n");
            if (string.IsNullOrEmpty(EmployeeName)) SB.Append("El campo 'Nombre' no puede estar vacío\n");
            if (string.IsNullOrEmpty(EmployeeFamilyName)) SB.Append("El campo 'Apellidos' no puede estar vacío");

        return SB.Length == 0;
        }
    }
}