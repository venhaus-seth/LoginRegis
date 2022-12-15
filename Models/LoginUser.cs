#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginRegis.Models;
public class LoginUser
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LEmail { get; set; }    
    
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LPassword { get; set; } 
    
}