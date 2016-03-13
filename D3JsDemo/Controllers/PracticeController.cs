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
    public class PracticeController : Controller
    {
        [OutputCache(Duration=100)]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult basicSVGShapes()
        {
            return View();
        }
        public ActionResult visualizingData()
        {
            return View();
        }
        public ActionResult GroupsAndAxes()
        {
            return View();
        }
        public ActionResult EnterUpdateExit()
        {
            return View();
        }
        public ActionResult Transitions()
        {
            return View();
        }
        public ActionResult WorkingWithArrays()
        {
            return View();
        }
        public ActionResult LoadingExternalData()
        {
            return View();
        }
        public ActionResult Paths()
        {
            return View();
        }
        public ActionResult Arcs()
        {
            return View();
        }
        public ActionResult PieLayout()
        {
            return View();
        }
        public ActionResult TreeLayout()
        {
            return View();
        }
        public ActionResult TreeLayout2()
        {
            return View();
        }
        public ActionResult ClusterPack()
        {
            return View();
        }
        public ActionResult Bubble()
        {
            return View();
        }
        public ActionResult HistogramLayout()
        {
            return View();
        }
        public ActionResult TreeMapLayout()
        {
            return View();
        }
        public ActionResult Maps()
        {
            return View();
        }
        public ActionResult colorLineChart()
        {
            return View();
        }
        public ActionResult BarChart()
        {
            return View();
        }
        public ActionResult PieChart()
        {
            return View();
        }
        public ActionResult Gauge()
        {
            return View();
        }
        public ActionResult SVGExample()
        {
            return View();
        }
    }
}