using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MyMVC.Pages
{
	
	public class BuildingModel : PageModel
    {
		public List<Onpageitem> OnPagesList = new List<Onpageitem>();

		//Land land1 = new Land(address: "Kaohsiung", landping: 40, owner: "Jason");
		public Land land = new Land();

		public void OnGet()
        {
			land = new Land
			{
				Address = "Kaohsiung",
				Landping = 40,
				Owner = "Jason",
			};

			//OnPagesList.Add(new Onpageitem { times = System.DateTime.Now, items= "==>OnGet" });
		}

		public void OnPost()
		{
		}

		public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
		{
			//OnPagesList.Add(new Onpageitem { times = System.DateTime.Now, items = "==>OnPageHandlerExecuted" });
			base.OnPageHandlerExecuted(context);			
		}

		public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
		{
			//OnPagesList.Add(new Onpageitem { times = System.DateTime.Now, items = "==>OnPageHandlerExecuting" });
			base.OnPageHandlerExecuting(context);			
		}

		public override Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
		{
			//OnPagesList.Add(new Onpageitem { times = System.DateTime.Now, items = "==>OnPageHandlerExecutionAsync" });
			return base.OnPageHandlerExecutionAsync(context, next);
		}

		public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
		{
			//OnPagesList.Add(new Onpageitem { times = System.DateTime.Now, items = "==>OnPageHandlerSelected" });
			base.OnPageHandlerSelected(context);
		}

		public override Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
		{
			//OnPagesList.Add(new Onpageitem { times = System.DateTime.Now, items = "==>OnPageHandlerSelectionAsync" });
			return base.OnPageHandlerSelectionAsync(context);
		}
	}

	public class Onpageitem
	{
		public DateTime times { get; set;  }

		public string items { get; set;  } 
	}
}