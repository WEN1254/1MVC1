using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Customer.Output
{
    public class CustomerRegister_Outputmodel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string CustomerName { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
    }
}