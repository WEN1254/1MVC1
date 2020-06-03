using MVC.Models;
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
        // GET: ProductList
        private mvcContext db = new mvcContext();
        // GET: ProductList
        public ActionResult Bestsellers()
        {
            string sqlQuery = @"select top 25 p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                        from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by [ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    order by p.Quantity";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult Outlet()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by [ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult New()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by [ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }

        public ActionResult LivingSofasAndSleeper()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=1";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult LivingSectionalSofas()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=2";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult LivingLoungeChairs()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=3";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult OttomansAndStools()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=4";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult LivingBenches()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=5";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult KidChairs()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=6";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult LivingAccentAndCoffeeTables()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=7";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult OfficeDesksAndTables()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=8";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult KidsDesk()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=9";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult BedroomBeds()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=10";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult KidsBeds()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=11";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult BedroomDressers()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=12";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult LivingBookcases()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=13";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult Rugs()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=14";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult PillowsAndCushions()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=15";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult Mirrors()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=16";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult Bedding()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=17";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
        public ActionResult Lighting()
        {
            string sqlQuery = @"select p.ProductID ,p.ProductName,ps.Price,ps.Image,p.Quantity
                                    from Products p
                                    join  (select *
                                    from(
	                                    select ROW_NUMBER()OVER(PARTITION BY [ProductID],[Price] ORDER by[ProductID])as rown,*
	                                    FROM [ProductSpecifications])AS T1
	                                    WHERE rown = 1) ps 
                                    on ps.ProductID=p.ProductID
                                    where p.SmallClassificationID=18";
            var Results = db.Database.SqlQuery<ProductListViewModels>(sqlQuery).ToList();
            return View(Results);
        }
    }
}