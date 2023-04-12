using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TP1.Models;
using TP1.Services;

namespace TP1.Pages;

public class IndexModel : PageModel
{
    public List<Movie> MovieList{get; set;}
    public Movie NewMovie { get; set; }
    
    public IndexModel()
    {
    }

    public void OnGet()
    {
      MovieList = MovieService.GetAll();
    }
    
    public IActionResult OnPost(){
        if(!ModelState.IsValid){
            return RedirectToPage("/Error");
        }
        
        MovieService.Add(NewMovie);

        return RedirectToAction("get");
    }
}
