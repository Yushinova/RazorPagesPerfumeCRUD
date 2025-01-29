using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPerfumeCRUD.Model;

namespace RazorPagesPerfumeCRUD.Pages.Perfumes
{
    public class Perfume_DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Perfume_DetailsModel(ApplicationDbContext context)
        {
            _db=context;
        }
        public Perfume PerfumeId { get; private set; } = new();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Perfume? perfume = await _db.Perfumes.FirstOrDefaultAsync(i => i.Id == id);
            if (perfume== null)
            {
                // 404 страница
                return NotFound();
            }
            PerfumeId = perfume;
            // 200 + текущая страница
            return Page();
        }
    }
}
