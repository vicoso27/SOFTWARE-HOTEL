// Pages/Admin/AdminModel.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SoftwareHotel.Data;
using SoftwareHotel.Models;

namespace SoftwareHotel.Pages.Admin
{
    public class AdminModel : PageModel
    {
        private readonly AppDbContext _context;

        public AdminModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Habitacion> Habitaciones { get; set; } = new();

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