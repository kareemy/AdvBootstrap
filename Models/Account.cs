using System.ComponentModel.DataAnnotations;

namespace AdvBootstrap.Models;

public enum HearOptions
{
    [Display(Name = "Google Search")]
    Google,
    [Display(Name = "Russian Prison Camp")]
    Russia,
    [Display(Name = "Other")]
    Other
}

public class Account
{
    [Display(Name = "First Name")]
    [StringLength(30, MinimumLength = 3)]
    [Required]
    public string FirstName {get; set;} = string.Empty;
    
    [Display(Name = "Last Name")]
    [StringLength(30, MinimumLength = 3)]
    [Required]
    public string LastName {get; set;} = string.Empty;

    [StringLength(30, MinimumLength = 8)]
    [Required]
    public string Password {get; set;} = string.Empty;

    [EmailAddress]
    public string Email {get; set;} = string.Empty;

    [Required]
    public HearOptions? Heard {get; set;}

    [Display(Name = "Subscribe to newsletter")]
    public bool SubscribeToNewsletter {get; set;}

    [Required(ErrorMessage = "You are required to enter yes/no.")]
    public bool Over18 {get; set;}
}