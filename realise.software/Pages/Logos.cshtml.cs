using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace realise.software.Pages;

public class LogosModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public LogosModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}

