using System.ComponentModel.DataAnnotations;

namespace PTPMQL.Models 
{
    public class Employee

{
    [Key]
    public string StudenID { get; set; }
    public string FullName { get; set; }
    public string Address { get; set; }

}
 
  }


