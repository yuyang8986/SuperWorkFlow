using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperWorkFlow.Models.Domain
{
    //Firm Client
    public class Client
    {
        [Key]
        public int ClientId { get; set; }    //PK

        [Required]
        [MaxLength(50)]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string Address { get; set; }
        public string PostalCode { get; set; }

        [Display(Name = "Primary Contact Person")]
        public string ContactPerson { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public int BusinessId { get; set; }           //fk

       
        //navigation property
        public virtual Business Business { get; set; }
    }
}