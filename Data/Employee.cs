using System.ComponentModel.DataAnnotations.Schema;

namespace GenericRepoPattern.Modal
{
    public class Employee
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int EmployeeID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Gender { get; set; }
        public Nullable<int> Salary { get; set; }
        [Column(TypeName = "varchar(200)")]
        [ForeignKey("Departments")]
        public int DepartmentID { get; set; }
    }
}
