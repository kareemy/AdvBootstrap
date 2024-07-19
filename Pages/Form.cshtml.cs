using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdvBootstrap.Models;

namespace AdvBootstrap.Pages;

public class FormModel : PageModel
{
    private readonly ILogger<FormModel> _logger;

    [BindProperty]
    public Account NewAccount {get; set;} = new();

    public FormModel(ILogger<FormModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("OnPost() Invalid Model State. Returning to previous page.");
            return Page();
        }

        _logger.LogInformation($"OnPost() Valid Model - {NewAccount.FirstName} {NewAccount.LastName}");
        _logger.LogInformation($"You heard us by - {NewAccount.Heard}");
        _logger.LogInformation($"Did you subscribe? - {NewAccount.SubscribeToNewsletter}");
        _logger.LogInformation($"Over 18? - {NewAccount.Over18}");
        return RedirectToPage("Success", NewAccount);
    }
}
