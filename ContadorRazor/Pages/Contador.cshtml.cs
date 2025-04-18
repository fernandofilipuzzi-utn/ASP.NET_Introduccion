using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContadorModel : PageModel 
{
    [BindProperty(SupportsGet = true)]
    public int Valor { get; set; } = 0;

    public void OnGet() {
        ///Valor++;
    }
}
