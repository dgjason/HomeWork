using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyMVC.HomeWork
{
    public class OfficeModel : PageModel
    {
		public const string caddress = "address";
		public const string crooms = "rooms";		

		public void OnGet()
        {
					
		}

        public void OnPost()
        {		
			ViewData[caddress] = Request.Form["in_address"];
			ViewData[crooms] = Request.Form["in_rooms"];
		}

	}	
}