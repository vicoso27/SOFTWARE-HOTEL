using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SoftwareHotel.Pages.Gallery
{
    public class GalleryModel : PageModel 
    {
        private readonly ILogger<GalleryModel> _logger; 

        public GalleryModel(ILogger<GalleryModel> logger) 
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
