using AloyWebRzr.Data;
using AloyWebRzr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AloyWebRzr.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly Db _db;
        public CreateModel(Db db)
        {
            _db = db;
        }

        public Category Category { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
