using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SusinLake.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public FileResult OnGetImage(string path) {
        var bytes = System.IO.File.ReadAllBytes(path);
        return File(bytes, "image/png");
    } // end OnGetImage()
}
