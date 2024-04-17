namespace EmployeeCRUDBlazor.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {MiddleName} {LastName}";
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Designation {  get; set; }



    }
}
