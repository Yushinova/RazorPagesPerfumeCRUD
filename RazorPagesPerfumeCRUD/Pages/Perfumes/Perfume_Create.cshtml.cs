using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPerfumeCRUD.Model;

namespace RazorPagesPerfumeCRUD.Pages.Perfumes
{
    public class Perfume_CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Perfume_CreateModel(ApplicationDbContext context)
        {
            _db = context;
        }
        // объект сущности, связанный с параметрами запроса - т.е. с формой
        [BindProperty]
        public Perfume PerfumeNew { get; set; } = new();
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _db.Perfumes.AddAsync(PerfumeNew);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Perfumes/Perfume_List");
        }
    }
}
