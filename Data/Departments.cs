using System.ComponentModel.DataAnnotations.Schema;

namespace GenericRepoPattern.Modal
{
    public class Departments
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int DepartmentID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string DepartmentName { get; set; }
    }
}
