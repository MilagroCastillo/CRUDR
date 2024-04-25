using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R.EN;
using R.LogicaNegocio;
using Microsoft.EntityFrameworkCore;



namespace R.UI.AppWebMVC.Controllers
{
    public class ControllerUserR : Controller
    {
        // GET: ControllerUserR
        public async Task <ActionResult> Index()
        {
            var usersR = await UserRBL.GetAll();

            return View(usersR);
        }

        // GET: ControllerUserR/Details/5
        public async Task <ActionResult> Details(int id)
        {
            var usersR = await UserRBL.GetById(new UserR { Id = id });
            if(usersR ==null)
            {
                return NotFound();
            }
            return View(usersR);
        }

        // GET: ControllerUserR/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControllerUserR/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserR pUserR)
        {
            try
            {
                var result = await UserRBL.Create( pUserR);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControllerUserR/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControllerUserR/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Edit(UserR pUserR)
        {
            try
            {
                var result = await UserRBL.Update(pUserR);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControllerUserR/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControllerUserR/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task < ActionResult> Delete(UserR pUserR)
        {
            try
            {
                var result = await UserRBL.Delete(pUserR);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            
        }
    }
}
