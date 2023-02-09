using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.Drawing.Text;


namespace WebApplication1.Pages
{
    [Authorize]
    public class CalendarModel : PageModel
    {
        
        public void OnGet()
        {
        }

        
    }
}
