using AloyWebRzr.Data;
using AloyWebRzr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AloyWebRzr.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly Db _db;
        public DeleteModel(Db db)
        {
            _db = db;
        }

        public Category Category { get; set; }

        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Category? obj = _db.Categories.Find(Category.Id);

            if (obj == null)
                return NotFound();

            _db.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
