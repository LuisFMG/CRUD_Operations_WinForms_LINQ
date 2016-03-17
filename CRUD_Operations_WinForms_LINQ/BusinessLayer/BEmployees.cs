using System.Windows.Forms;
using CRUD_Operations.Data;
using CRUD_Operations.Entities;

namespace CRUD_Operations.Business
{
    public class BEmployees
    {
        DEmployee CRUDEmployees = new DEmployee();

        public bool RegisterEmployee(EEmployees EmployeeData)
        {
            bool Result = false;

            if (EmployeeData != null)
            {
                Result = true;
                CRUDEmployees.RegisterEmployee(EmployeeData);
            }

        return Result;
        }

        public bool SearchEmployee(int IdEmployee, DataGridView DgvEmployees)
        {
            bool Result = false;

            if (CRUDEmployees.SearchEmployee(IdEmployee, DgvEmployees))
            {
                Result = true;
            }

        return Result;
        }

        public bool UpdateEmployee(EEmployees EmployeeData)
        {
            bool Result = false;

            if (EmployeeData != null)
            {
                Result = true;
                CRUDEmployees.UpdateEmployees(EmployeeData);
            }

        return Result;
        }

        public int DeleteEmployee(int IdEmployee)
        {

        return CRUDEmployees.DeleteEmployees(IdEmployee);
        }

        public int SearchAndLoadIdEmployee(out int IdEmployee)
        {
            CRUDEmployees.SearchAndLoadIdEmployee(out IdEmployee);

        return IdEmployee;
        }

        public bool SeekForUpdate(int IdEmployee, EEmployees EmployeeData)
        {
            bool Result = false;

            if (CRUDEmployees.SeekForUpdate(IdEmployee, EmployeeData))
            {
                Result = true;
            }

        return Result;
        }
    }
}