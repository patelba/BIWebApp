using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIWebApp.Data;
using BIWebApp.Services;
using WebGrease;

namespace BIWebApp.Controllers
{
    public class CostController : Controller
    {
        // GET: Cost
        public ActionResult Index()
        {

            var costService = new CostService();
            var costs=costService.GetCosts();
            return View(costs);
        }
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cost/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var costService = new CostService();
                var cost = new BI_K3_Costs()
                {
                    BI_CostID = 0,
                    Role_Type = collection["role_type"],
                    Role_Name = collection["role_name"]
                   
                };
                if (collection["daily_cost"] != null)
                {
                    cost.Daily_Cost = decimal.Parse(collection["daily_cost"]);
                }
                if (collection["hourly_cost"] != null)
                {
                    cost.Hourly_Cost = decimal.Parse(collection["hourly_cost"]);
                }
                costService.InsertCost(cost);
                return RedirectToAction("Index");
            }
            catch (Exception exception) 
            {
                return View();
            }
        }

        //
        // GET: /Cost/Edit/5
        public ActionResult Edit(int id)
        {
            var costService = new CostService();
            var cost = costService.GetCostById(id);

            return View(cost);
        }

        //
        // POST: /Cost/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var costService = new CostService();

                var cost = new BI_K3_Costs()
                {
                    BI_CostID = int.Parse(collection["BI_CostID"]),
                    Role_Type = collection["role_type"],
                    Role_Name = collection["role_name"]

                };
                if (collection["daily_cost"] != null)
                {
                    cost.Daily_Cost = decimal.Parse(collection["daily_cost"]);
                }
                if (collection["hourly_cost"] != null)
                {
                    cost.Hourly_Cost = decimal.Parse(collection["hourly_cost"]);
                }
                costService.UpdateCost(cost);
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }

        //
        // GET: /Cost/Delete/5
        public ActionResult Delete(int id)
        {
            var costService = new CostService();
            var cost = costService.GetCostById(id);
            return View(cost);
        }

        //
        // POST: /CodeCombination/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var costService = new CostService();
                var cost = costService.GetCostById(id);
                costService.DeleteCost(cost);
                return RedirectToAction("Index");
            }
            catch (Exception exception)
            {
                return View();
            }
        }


    }
}