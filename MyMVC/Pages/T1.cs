using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyMVC.Pages
{
    public class T1
    {
        [StringLength(10, ErrorMessage = "{0} 長度必須介於2與10字元之間", MinimumLength = 2)]
        [Required(ErrorMessage = "{0} 必須輸入")]
        [Display(Name = "姓名",Prompt = "Ex:Johnny")]
        public String Name { get; set; }

        [Required(ErrorMessage = "{0} 必須輸入")]
        [Display(Name = "到職日")]
        public DateTime EnterDate { get; set; }
    }
}
