using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPerfumeCRUD.Model;

namespace RazorPagesPerfumeCRUD.Pages.Perfumes
{

    public class Perfume_DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Perfume_DeleteModel(ApplicationDbContext context)
        {
            _db = context;
        }
        public Perfume DeletPerfume { get; private set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            // получить парфюм
            Perfume? deleting = await _db.Perfumes.FirstOrDefaultAsync(i => i.Id == id);
            if (deleting == null)
            {
                return NotFound();
            }
            DeletPerfume = deleting;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Perfume? deleting = await _db.Perfumes.FirstOrDefaultAsync(i => i.Id == id);
            if (deleting == null)
            {
                return NotFound();
            }
            _db.Perfumes.Remove(deleting);
            await _db.SaveChangesAsync();
            // редирект
            return RedirectToPage("/Perfumes/Perfume_List");
        }
    }
}
