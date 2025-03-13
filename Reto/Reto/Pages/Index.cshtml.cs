using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Reto.Pages;

public class IndexModel : PageModel
{
    public int? empleadoId {get; set;}
    public string? contraseña {get; set;}
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPostCrearCuenta() {
        Response.Redirect("CrearCuenta");
    }
}
