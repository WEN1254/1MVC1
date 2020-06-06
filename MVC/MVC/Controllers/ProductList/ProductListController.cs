using MVC.Models;
using MVC.Models.Repository.BussinessLogicLayer;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProductListController : Controller
    {
        private ProductBLO _ProductBLO = new ProductBLO();
        public ProductListController()
        {
            _ProductBLO = new ProductBLO();
        }
        // GET: ProductList
        public ActionResult New(string sortOrder)
        {
            var queryresult = _ProductBLO.GetAll();
            ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
            ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
            ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
            ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
            ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
            switch (sortOrder)
            {
                case "Quantity":
                    queryresult = queryresult.OrderBy(s => s.Quantity).ToList();
                    break;
                case "Name":
                    queryresult = queryresult.OrderBy(s => s.ProductName).ToList();
                    break;
                case "Name_desc":
                    queryresult = queryresult.OrderByDescending(s => s.ProductName).ToList();
                    break;
                case "Price":
                    queryresult = queryresult.OrderBy(s => s.Price).ToList();
                    break;
                case "Price_desc":
                    queryresult = queryresult.OrderByDescending(s => s.Price).ToList();
                    break;
                default:
                    break;
            }
            return View(queryresult);
        }
        public ActionResult Category(int type ,string sortOrder)
        {
            var queryresult = _ProductBLO.GetAll().Where(x => x.SmallClassificationID == type);
            ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
            ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
            ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
            ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
            ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
            switch (sortOrder)
            {
                case "Quantity":
                    queryresult = queryresult.OrderBy(s => s.Quantity).ToList();
                    break;
                case "Name":
                    queryresult = queryresult.OrderBy(s => s.ProductName).ToList();
                    break;
                case "Name_desc":
                    queryresult = queryresult.OrderByDescending(s => s.ProductName).ToList();
                    break;
                case "Price":
                    queryresult = queryresult.OrderBy(s => s.Price).ToList();
                    break;
                case "Price_desc":
                    queryresult = queryresult.OrderByDescending(s => s.Price).ToList();
                    break;
                default:
                    break;
            }
             return View(queryresult);          
        }
        // GET: ProductList
        //public ActionResult Bestsellers(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select top 25 p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                                from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by [ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            order by p.Quantity";
        //    var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
        //    switch (sortOrder)
        //    {
        //        case "Quantity":
        //            Results = Results.OrderBy(s => s.Quantity).ToList();
        //            break;
        //        case "Name":
        //            Results = Results.OrderBy(s => s.ProductName).ToList();
        //            break;
        //        case "Name_desc":
        //            Results = Results.OrderByDescending(s => s.ProductName).ToList();
        //            break;
        //        case "Price":
        //            Results = Results.OrderBy(s => s.Price).ToList();
        //            break;
        //        case "Price_desc":
        //            Results = Results.OrderByDescending(s => s.Price).ToList();
        //            break;
        //        default:
        //            break;
        //    }
        //    return View(Results);
        //}
   
    }
}