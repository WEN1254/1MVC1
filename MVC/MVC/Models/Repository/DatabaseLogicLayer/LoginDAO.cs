using Dapper;
using MVC.Models.Database;
using MVC.ViewModels.Customer;
using MVC.ViewModels.Customer.Input;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC.Models.Repository.DatabaseLogicLayer
{
    public class LoginDAO
    {
        private string SQLConnectionStr = ConfigurationManager.ConnectionStrings["mvcContext"].ConnectionString;
        public IEnumerable<Customer> GetAllMember()
        {
            string SQLcommand = @"SELECT * FROM Customer";

            IEnumerable<Customer> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Customer>(SQLcommand);
            }

            return result;
        }
        public IEnumerable<Customer> Login_CheckAccount(CustomerLogin_Inputmodel Input)
        {
            string Sqlcommand = @" SELECT Email from Customer where Email=@L1";

            IEnumerable<Customer> result;
            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Customer>(Sqlcommand, new { L1 = Input.Email });
            }
            return result;
        }
        public IEnumerable<Customer> Login_CheckPassword(CustomerLogin_Inputmodel Input)
        {
            string Sqlcommand = @" SELECT Password from Customer where Password=@L1";

            IEnumerable<Customer> result;
            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Customer>(Sqlcommand, new { L1 = Input.Email });
            }
            return result;
        }
        public IEnumerable<Customer> Register(CustomerRegister_Inputmodel Input)
        {
            string Sqlcommand = @" INSERT INTO Customer(Email,Password,Birthday,CustomerName,Phone)
                                   VALUES (@c1,@c2,@c3,@c4,@c5)";

            IEnumerable<Customer> result;

            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Customer>(Sqlcommand, new { c1 = Input.Email, c2 = Input.Password, c3 = Input.Birthday, c4 = Input.CustomerName, c5 = Input.Phone });
            }
            return result;
        }
        public IEnumerable<Customer> CheckAccount(string Email)
        {


            string Sqlcommand = @" SELECT * from Customer Where Email=@Email";



            IEnumerable<Customer> result;
            using (SqlConnection conn = new SqlConnection(SQLConnectionStr))
            {
                result = conn.Query<Customer>(Sqlcommand, new { CustomerEmail = Email });
            }
            return result;
        }
    }
}