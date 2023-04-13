namespace NFS.WEB.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public int TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public int Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }

    }


}
