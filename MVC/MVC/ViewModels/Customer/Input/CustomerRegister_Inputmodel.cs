using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ViewModels.Customer.Input
{
    public class CustomerRegister_Inputmodel
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string CustomerName { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
    }
}