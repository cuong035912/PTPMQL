using System.ComponentModel.DataAnnotations;

namespace DemoMvc.Models;

public class Person
{
    [Key]
    public string cancuoccongdan { get; set;}
    public string hoten { get; set;}
    
    public string quequan { get; set;}
}
