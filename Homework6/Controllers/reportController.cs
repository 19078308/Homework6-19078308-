using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Homework6.Models;

namespace Homework6.Controllers
{
    public class reportController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: report
        public ActionResult Index()
        {
            try
            {
                ViewBag.DataPoints = JsonConvert.SerializeObject(db.products.ToList(), _jsonSetting);

                return View();
            }
            catch (System.Data.Entity.Core.EntityException)
            {
                return View("Error");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return View("Error");
            }
        }
        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
     
        }
    }
