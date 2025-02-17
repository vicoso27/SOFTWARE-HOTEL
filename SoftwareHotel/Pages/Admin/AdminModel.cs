
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoftwareHotel.Data;
using SoftwareHotel.Models;

public class AdminPageModel : PageModel

{
    public class AdminModel : PageModel
    {
        private readonly AppDbContext _context;

        public AdminModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Habitacion>? Habitaciones { get; private set; }

        public async Task OnGetAsync()
        {
            Habitaciones = await _context.Habitaciones.ToListAsync();
            if (Habitaciones == null)
            {
                Habitaciones = new List<Habitacion>();
            }
        }
    }
}