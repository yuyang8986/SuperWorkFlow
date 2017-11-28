using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperWorkFlow.Models.Domain
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public PositionType Position { get; set; }

        [Range(0,10000)]
        [Display(Name = "Billable Hour Rate")]
        public int BillableHourRate { get; set; }

        [Range(0,1000)]
        [Display(Name = "Actual Hourly Salary")]
        public int InternalHourRate { get; set; }

        public PermissionType Permissons { get; set; }

        //Navigation Property
        public Business Business { get; set; }
    }
}