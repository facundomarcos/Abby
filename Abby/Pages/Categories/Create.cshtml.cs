using Abby.Data;
using Abby.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

       // [BindProperty]
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPost()
        {
            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
