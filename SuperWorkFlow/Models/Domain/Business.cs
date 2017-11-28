using SuperWorkFlow.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperWorkFlow.Models
{
    //Firm
    //Business:Client = 1:N
    //Business:Employee = 1:N
    public class Business
    {
        [Key]
        public int BusinessId { get; set; }    //PK
        public string BusinessName { get; set; }

        //sub-domain related
        [Required]
        //[UniqueSubdomainNameForBusiness]
        public string SubdomainName { get; set; } //the unique sub domain part of the url e.g. smsf.superworkflow.net ,  sub domain is smsf

        public string CustomDomain { get; set; }   //custom domain set by user to map to the sub-domain 
        public bool EnableCustomDomain { get; set; } //indicate custom-domain mapping successfully.

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        //[UniqueEmailForBusiness]
        public string Email { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Phone]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }

        [Display(Name = "Logo Image Path")]
        public string LogoImagePath { get; set; }              

        [Display(Name = "Unlimited Active Client")]
        public bool ApplyUnlimitedActiveClientNumPlan { get; set; }  //indicate if apply unlimited plan

        public string TermsAndConditionsUrl { get; set; }      //external url for terms&conditions(optional)
        public string PrivacyPoliciesUrl { get; set; }         //external url for privacy policies(optional)

        [Display(Name = "Super-Business")]
        public bool IsSuperAdminBusiness { get; set; }

        //fk


        //navigation property
       
        //public virtual ICollection<BusinessType> BusinessTypes { get; set; }  //Business types
        public virtual ICollection<Client> Clients { get; set; }  //Clients
        public virtual ICollection<Report> Reports { get; set; }      //Reports
    
    }
}