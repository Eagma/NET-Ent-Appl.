using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Student
    {
        [Required]
        [BindProperty(Name = "FirstName")]
        public string FirstName {
            get;
            set;
        }


        [Required]
        [BindProperty(Name = "lastName")]
        public string LastName {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        [BindProperty(Name = "email")]
        public string EmailAddress {
            get;
            set;
        }

        [Required]
        [BindProperty(Name = "id")]
        public string StudentId {
            get;
            set;
        }

        [Required]
        [BindProperty(Name = "description")]
        public string Description {
            get;
            set;
        }
    }
}