using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace demo_app.Pages
{
  public class IndexModel : PageModel
  {
    public string Greet { get; set; }
    
    public void OnGet()
    {
      Greet = "Hey there!";
    }
  }
}
