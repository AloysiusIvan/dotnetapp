using AloyWebRzr.Data;
using AloyWebRzr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AloyWebRzr.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly Db _db;
        public EditModel(Db db)
        {
            _db = db;
        }

        public Category Category { get; set; }

        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
