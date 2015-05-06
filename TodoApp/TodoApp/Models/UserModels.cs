using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using TodoApp.Models;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class UserModels
    {
        [Required]
        [Display(Name = "User name")]
        public string Username 
        { 
            get;
            set;
        }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password 
        { 
            get;
            set; 
        }

        public void auth(User user)
        {       
            
        }
    }
    public class UserRegistration
    {
        [Required]
        [Display(Name = "Username")]
        public string Username
        {
            set;
            get;
        }

        [Required]
        [StringLength(100, ErrorMessage = "Your password is too short!", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password
        {
            set;
            get;
        }
    }
}