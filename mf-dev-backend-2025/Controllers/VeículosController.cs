using mf_dev_backend_2025.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2025.Controllers
{
    public class VeículosController: Controller
    {
        private readonly AppDbContext _context;
        public VeículosController(AppDbContext context)
        {
            _context = context;
        }

        // cada função aqui no controller é uma página
        public async Task<IActionResult> Index() { 
            var dados = await _context.Veículos.ToListAsync();
            return View(dados); 
        }
    }
}
