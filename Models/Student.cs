using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Student
    {
        [Required]
        public string? FirstName {
            get;
            set;
        }


        [Required]
        public string? LastName {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        public string? EmailAddress {
            get;
            set;
        }

        [Required]
        public string? StudentId {
            get;
            set;
        }

        [Required]
        public string? Description {
            get;
            set;
        }
    }
}