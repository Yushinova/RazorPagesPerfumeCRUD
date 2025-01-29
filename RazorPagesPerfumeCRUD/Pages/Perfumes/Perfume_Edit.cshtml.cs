using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesPerfumeCRUD.Model;

namespace RazorPagesPerfumeCRUD.Pages.Perfumes
{  
    public class Perfume_EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Perfume_EditModel(ApplicationDbContext context)
        {
            _db = context;
        }
        [BindProperty]
        public Perfume PerfumeEdit { get; set; } = new();
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Perfume? edit = await _db.Perfumes.FirstOrDefaultAsync(p => p.Id == id);
            if (edit == null)
            {
                // 404 ��������
                return NotFound();
            }
            PerfumeEdit = edit;
            // 200 + ������� ��������
            return Page();

        }
        public async Task<IActionResult> OnPostAsync()
        {
            // �������� ��������� ������
            Perfume? edit = await _db.Perfumes.FirstOrDefaultAsync(i => i.Id == PerfumeEdit.Id);
            if (edit == null)
            {
                // 404 ��������
                return NotFound();
            }
            //���������� ������
            edit.Name = PerfumeEdit.Name;
            edit.Brand = PerfumeEdit.Brand;
            edit.Description = PerfumeEdit.Description;
            edit.Gender = PerfumeEdit.Gender;
            edit.Notes = PerfumeEdit.Notes;
            edit.Volume = PerfumeEdit.Volume;
            edit.Price = PerfumeEdit.Price;
            edit.isSale = PerfumeEdit.isSale;
            await _db.SaveChangesAsync();
            // � �������� ���������� ��������� ��������������� �� ������ ���
            return RedirectToPage("/Perfumes/Perfume_List");
        }
    }
}
