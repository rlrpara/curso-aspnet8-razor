using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Web.Pages;

public class IndexModel : PageModel
{
    public string? Title { get; set; }
    public void OnGet()
    {
        Title = "Página inicial";
    }
}
