using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cachetest.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string Language { get; set; }
        public string WelcomeMessage { get; set; }
        public string FirstVisitDate {get;set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


      
        public void OnGet()
        {
            // CookieOptions cookieOptions = new CookieOptions();

            // if(!HttpContext.Request.Cookies.ContainsKey("first_request"))
            // {

            //     cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7));
            //     HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(),cookieOptions);
                
            //     WelcomeMessage = "Welcome, new visitor!";
            // } else {
            //     DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_request"]);
            //     WelcomeMessage = "Welcome back, user!" ;
            //     FirstVisitDate = "your first visit was on:" + firstRequest.ToString();
            // }
            

        }

        
       
    }
}
