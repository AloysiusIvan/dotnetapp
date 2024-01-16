using AloyWebRzr.Data;
using AloyWebRzr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AloyWebRzr.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Db _db;
        public IndexModel(Db db)
        {
            _db = db;
        }

        public List<Category> CategoryList { get; set; }

        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
