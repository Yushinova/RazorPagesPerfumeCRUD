using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPerfumeCRUD.Model;

namespace RazorPagesPerfumeCRUD.Pages.Perfumes
{
    public class Perfume_ListModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Perfume_ListModel(ApplicationDbContext context)
        {
            _db = context;
        }
        // свойства модели страницы
        public List<Perfume> Perfumes { get; private set; } = new();
        public async Task OnGetAsync()
        {
            Perfumes = await _db.Perfumes.ToListAsync();
        }
    }
}
