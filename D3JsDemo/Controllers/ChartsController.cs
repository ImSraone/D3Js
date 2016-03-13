using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace PowerBI.Controllers
{
    public class ChartsController : Controller
    {
        [OutputCache(Duration = 100)]
        public ActionResult AllCharts()
        {
            // for creating new Dataset in Power BI
            //var response = createDataset(Session["AccessToken"].ToString());
            return View();
        }
        public ActionResult pieChart()
        {
            return View();
        }
        public ActionResult stackedColumnChart()
        {
            return View();
        }
        public ActionResult collapsibleTreeChart()
        {
            return View();
        }
        public ActionResult areaChart()
        {
            return View();
        }
        public ActionResult simpleBarChart()
        {
            return View();
        }
        public ActionResult lineChart()
        {
            return View();
        }
        public ActionResult GeoNamesExtract()
        {
            return View();
        }
        public ActionResult DraggableNodes()
        {
            return View();
        }
    }
}