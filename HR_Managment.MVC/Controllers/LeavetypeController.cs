using HR_Managment.MVC.Contracts;
using HR_Managment.MVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Managment.MVC.Controllers
{
    public class LeavetypeController : Controller
    {
        private readonly ILeaveTypeService _leaveTypeService;
     
        public LeavetypeController(ILeaveTypeService leaveTypeService)
        {
            _leaveTypeService = leaveTypeService;
            
        }


        // GET: LeavetypeController
        public  async Task<ActionResult> Index()
        {
            var listLeavetype = await _leaveTypeService.GetLeaveTyps();
            return View(listLeavetype);
        }

        // GET: LeavetypeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LeavetypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeavetypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeavetypeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LeavetypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LeavetypeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LeavetypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
