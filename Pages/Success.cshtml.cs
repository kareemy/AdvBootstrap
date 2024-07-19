using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdvBootstrap.Models;

namespace AdvBootstrap.Pages;

public class SuccessModel : PageModel
{
    private readonly ILogger<SuccessModel> _logger;

    [BindProperty]
    public Account NewAccount {get; set;} = default!;

    public SuccessModel(ILogger<SuccessModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(Account _newAccount)
    {
        NewAccount = _newAccount;
        _logger.LogWarning($"OnGet() - {NewAccount.FirstName}");
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("OnPost() Invalid Model State. Returning to previous page.");
            return RedirectToPage("/Form");
        }
        _logger.LogWarning($"OnPost() - {NewAccount.FirstName}");
        return Page();
    }
}
