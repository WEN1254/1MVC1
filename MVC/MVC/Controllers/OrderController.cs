﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MVC.Models.OrderModel;

namespace MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        //[Authorize]
        [HttpPost]
        public ActionResult Index(Models.OrderModel.Ship postback)
        {
            if (this.ModelState.IsValid)
            {
                var currentcart = Models.Carts.Operation.GetCurrentCart();
                var UserId = 1;
                using(Models.Database._1MVC1Model db=new Models.Database._1MVC1Model())
                {
                    var order = new Models.Database.Order()
                    {
                        CustomerID=UserId,
                        RecieverName=postback.RecieverName,
                        RecieverPhone=postback.RecieverPhone,
                        RecieverAddress=postback.RecieverAddress
                    };
                    db.Orders.Add(order);
                    db.SaveChanges();

                    var orderDetail = currentcart.ToOrderDetailList(order.OrderID);
                    db.OrderDetails.AddRange(orderDetail);
                    db.SaveChanges();

                }
                //return Content("訂購");
            }
            return View();
        }
    }
}