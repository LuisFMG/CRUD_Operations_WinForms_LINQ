using System;

namespace CRUD_Operations.Entities
{
    public class EEmployees
    {
        public int IdEmployee { get; set; }

        public DateTime DateOfHire { get; set; }

        public byte[] PhotoEmployee { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeFamilyName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string UserPassword { get; set; }
    }
}