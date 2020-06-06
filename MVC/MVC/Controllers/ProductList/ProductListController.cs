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
        public ActionResult New()
        {
            var queryresult = _ProductBLO.GetAll();

            return View(queryresult);
        }
        public ActionResult Category(int type)
        {
            var queryresult = _ProductBLO.GetAll().Where(x => x.SmallClassificationID == type);

            
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
        //public ActionResult Outlet(string sortOrder)

        //{

        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by [ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID";
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
        //public ActionResult New(string sortOrder)
        //{

        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";

        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by [ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID";
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

        //public ActionResult LivingSofasAndSleeper(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=1";
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
        //public ActionResult LivingSectionalSofas(string sortOrder)
        //{

        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=2";
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
        //public ActionResult LivingLoungeChairs(string sortOrder)
        //{

        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=3";
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
        //public ActionResult OttomansAndStools(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=4";
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
        //public ActionResult LivingBenches(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=5";
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
        //public ActionResult KidChairs(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=6";
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
        //public ActionResult LivingAccentAndCoffeeTables(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=7";
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
        //public ActionResult OfficeDesksAndTables(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=8";
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
        //public ActionResult KidsDesk(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=9";
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
        //public ActionResult BedroomBeds(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=10";
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
        //public ActionResult KidsBeds(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=11";
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
        //public ActionResult BedroomDressers(string sortOrder)
        //{

        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=12";
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
        //public ActionResult LivingBookcases(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=13";
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
        //public ActionResult Rugs(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=14";
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
        //public ActionResult PillowsAndCushions(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=15";
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
        //public ActionResult Mirrors(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=16";
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
        //public ActionResult Bedding(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=17";
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
        //public ActionResult Lighting(string sortOrder)
        //{
        //    ViewBag.QuantityParm = String.IsNullOrEmpty(sortOrder) ? "Quantity" : "Quantity";
        //    ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "Name" : "Name";
        //    ViewBag.NamedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Name_desc" : "Name_desc";
        //    ViewBag.PriceSortParm = String.IsNullOrEmpty(sortOrder) ? "Price" : "Price";
        //    ViewBag.PricedescSortParm = String.IsNullOrEmpty(sortOrder) ? "Price_desc" : "Price_desc";
        //    ViewBag.ResetParm = String.IsNullOrEmpty(sortOrder) ? "" : "";
        //    string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
        //                            from Products p
        //                            join  (select *
        //                            from(
	       //                             select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	       //                             FROM [ProductSpecifications])AS T1
	       //                             WHERE rown = 1) ps 
        //                            on ps.ProductID=p.ProductID
        //                            where p.SmallClassificationID=18";
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