using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyMVC.Pages
{
    public class ThoroughModel : PageModel
    {
		public House1 house = new House1();

		public void OnGet()
        {
			//ViewData["address"] = house.Address;
			//ViewData["rooms"] = house.Rooms;
		}

		//public void OnPost(String address, String rooms, House house)
		public void OnPost(House1 house)
		{
			//house.Address = address;
			//house.Rooms = rooms;

			ViewData["address"] = house.Address;
			ViewData["rooms"] = house.Rooms;			
		}

		public class House1
		{
			public string Address { get; set; }
			public string Rooms { get; set; }
		}
	}
}