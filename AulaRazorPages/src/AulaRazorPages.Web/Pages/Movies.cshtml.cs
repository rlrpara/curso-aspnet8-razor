using AulaRazorPages.Web.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AulaRazorPages.Web.Pages;

public class MoviesModel(MoviesContext moviesContext) : PageModel
{
    public ICollection<Movie>? Movies { get; private set; }
    public void OnGet()
    {
        Movies = moviesContext.Movies.ToList();
    }
    //public async Task OnGetAsync()
    //{
    //    Movies = await moviesContext.Movies.ToListAsync();
    //}
}
