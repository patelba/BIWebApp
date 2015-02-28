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
    //[Authorize(Users = @"k3btg\Bhupendra.Patel")]
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
        public ActionResult Create(BI_K3_Costs modelCosts)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var costService = new CostService();
                    costService.InsertCost(modelCosts);
                    return RedirectToAction("Index");
                }
                return View(modelCosts);
            }
            catch (Exception exception) 
            {
                return View(modelCosts);
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
        public ActionResult Edit(BI_K3_Costs cost)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var costService = new CostService();
                    costService.UpdateCost(cost);
                    return RedirectToAction("Index");
                }

                return View(cost);
               
            }
            catch (Exception exception)
            {
                return View(cost);
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
        public ActionResult Delete(int id,FormCollection collection)
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