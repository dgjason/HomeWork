using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyMVC.Pages
{
    public class formModel : PageModel
    {
        [BindProperty]
        public T1 Owner { get; set; }

        public String Message { get; set; }

        public void OnGet()
        {
			Owner = new T1() { EnterDate = DateTime.Now.Date };
        }

        public void OnPost()
        {

        }

        public void OnPostShow()
        {
            Message = $"收到表單內容：{Owner.Name}, {Owner.EnterDate.ToShortDateString()}";
        }

        public IActionResult OnPostClear()
        {
            return RedirectToPage();
        }

        public override Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return base.OnPageHandlerSelectionAsync(context);
        }

        public override void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            base.OnPageHandlerSelected(context);
        }

        public override Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            return base.OnPageHandlerExecutionAsync(context, next);
        }

        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            base.OnPageHandlerExecuting(context);
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            base.OnPageHandlerExecuted(context);
        }


        

        

        
    }
}
