using System.Linq;
using System.Windows.Forms;
using CRUD_Operations.Entities;

namespace CRUD_Operations.Data
{
    public class DEmployee
    {
        DB_CRUD_EmployeesDataContext DBEmployees;

        public void RegisterEmployee(EEmployees EmployeeData)
        {
            using (DBEmployees = new DB_CRUD_EmployeesDataContext())
            {
                User DBTableUsers = new User();
                Employee DBTableEmployees = new Employee();

                DBTableUsers.Id_User = EmployeeData.IdEmployee;
                DBTableUsers.Username = EmployeeData.Username;
                DBTableUsers.User_Password = EmployeeData.UserPassword;
                DBTableEmployees.Id_Employee = EmployeeData.IdEmployee;
                DBTableEmployees.Date_Of_Hire = EmployeeData.DateOfHire;
                DBTableEmployees.Photo_Employee = EmployeeData.PhotoEmployee;
                DBTableEmployees.Employee_Name = EmployeeData.EmployeeName;
                DBTableEmployees.Employee_Family_Name = EmployeeData.EmployeeFamilyName;
                DBTableEmployees.Date_Of_Birth = EmployeeData.DateOfBirth;
                DBTableEmployees.Age = EmployeeData.Age;
                DBTableEmployees.Email = EmployeeData.Email;
                DBTableEmployees.Id_User = EmployeeData.IdEmployee;

                DBEmployees.Users.InsertOnSubmit(DBTableUsers);
                DBEmployees.Employees.InsertOnSubmit(DBTableEmployees);
                DBEmployees.SubmitChanges();
            }
        }

        public bool SearchEmployee(int IdEmployee, DataGridView DgvEmployees)
        {
            bool Result = false;
            DgvEmployees.AutoGenerateColumns = false;

            using (DBEmployees = new DB_CRUD_EmployeesDataContext())
            {
                if (IdEmployee != 0)
                {
                    var QueryFilter = (from Users in DBEmployees.Users
                                 join Employees in DBEmployees.Employees
                                 on Users.Id_User equals Employees.Id_Employee
                                 where IdEmployee == Users.Id_User
                                 select new
                                 {
                                     Users.Id_User,
                                     Users.Username,
                                     Users.User_Password,
                                     Employees.Date_Of_Hire,
                                     Employees.Employee_Name,
                                     Employees.Employee_Family_Name,
                                     Employees.Date_Of_Birth,
                                     Employees.Age,
                                     Employees.Email
                                 });

                    DgvEmployees.DataSource = QueryFilter.ToList();
                }
                else
                {
                    var Query = (from Users in DBEmployees.Users
                                 join Employees in DBEmployees.Employees
                                 on Users.Id_User equals Employees.Id_Employee
                                 select new
                                 {
                                     Users.Id_User,
                                     Users.Username,
                                     Users.User_Password,
                                     Employees.Date_Of_Hire,
                                     Employees.Employee_Name,
                                     Employees.Employee_Family_Name,
                                     Employees.Date_Of_Birth,
                                     Employees.Age,
                                     Employees.Email
                                 });

                    DgvEmployees.DataSource = Query.ToList();
                }
                
                if (DgvEmployees.RowCount != 0)
                {
                    Result = true;
                }
            }
        
        return Result;
        }

        public void UpdateEmployees(EEmployees EmployeeData)
        {
            using (DBEmployees = new DB_CRUD_EmployeesDataContext())
            {
                Employee DBTableEmployees = new Employee();
                User DBTableUsers = new User();

                DBTableUsers = DBEmployees.Users.SingleOrDefault(X => X.Id_User == EmployeeData.IdEmployee);
                DBTableEmployees = DBEmployees.Employees.SingleOrDefault(X => X.Id_Employee == EmployeeData.IdEmployee);

                DBTableUsers.Username = EmployeeData.Username;
                DBTableUsers.User_Password = EmployeeData.UserPassword;
                DBTableEmployees.Employee_Name = EmployeeData.EmployeeName;
                DBTableEmployees.Employee_Family_Name = EmployeeData.EmployeeFamilyName;
                DBTableEmployees.Email = EmployeeData.Email;

                DBEmployees.SubmitChanges();
            }              
        }

        public int DeleteEmployees(int IdEmployee)
        {
            int Result = -1;

            using (DBEmployees = new DB_CRUD_EmployeesDataContext())
            {
                var Query = (from Users in DBEmployees.Users
                             where Users.Id_User == IdEmployee
                             select Users);

                foreach (var X in Query)
                {
                    DBEmployees.Users.DeleteOnSubmit(X);
                }

                Result = Query.Count();
                DBEmployees.SubmitChanges();
            }

        return Result;
        }

        public int SearchAndLoadIdEmployee(out int IdEmployee)
        {
            using (DBEmployees = new DB_CRUD_EmployeesDataContext())
            {
                var Query = (from Employee in DBEmployees.Employees
                            select Employee.Id_Employee);

                if (Query.Count() == 0)
                {
                    IdEmployee = 1599;

                return IdEmployee;
                }
                else
                {

                return IdEmployee = Query.Max();
                }
            }
        }

        public bool SeekForUpdate(int IdEmployee, EEmployees EmployeeData)
        {
            bool Result = false;

            using (DBEmployees = new DB_CRUD_EmployeesDataContext())
            {
                var Query = (from Users in DBEmployees.Users
                             join Employees in DBEmployees.Employees
                             on Users.Id_User equals Employees.Id_Employee
                             where Users.Id_User == IdEmployee
                             select new
                             {
                                 Users.Username,
                                 UserPassword = Users.User_Password,
                                 EmployeeName = Employees.Employee_Name,
                                 EmployeeFamilyName = Employees.Employee_Family_Name,
                                 Email = Employees.Email
                             });

                foreach(var X in Query)
                {
                    EmployeeData.Username = X.Username.ToString();
                    EmployeeData.UserPassword = X.UserPassword.ToString();
                    EmployeeData.EmployeeName = X.EmployeeName.ToString();
                    EmployeeData.EmployeeFamilyName = X.EmployeeFamilyName.ToString();
                    EmployeeData.Email = X.Email.ToString();
                }

                if (Query.Count() != 0)
                {
                    Result = true;
                }
            }

        return Result;
        }
    }
}