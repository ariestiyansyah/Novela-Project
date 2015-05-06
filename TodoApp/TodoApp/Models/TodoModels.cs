using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class TodoModels
    {
        //Todo
        public string Description
        {
            set;
            get;
        }
        public string idUser
        {
            set;
            get;
        }
    }
    public class TodoViewModels
    {
        [Required]
        [Display(Name = "Description")]
        public string Description
        {
            set;
            get;
        }
    }
}