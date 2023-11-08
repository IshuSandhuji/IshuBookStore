using Microsoft.AspNetCore.Mvc;
using IshuBookStore.DataAccess.Respository;
using IshuBooks.Models;

namespace IshuBookStore.Areas.Customer.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        
            private readonly UnitOFWork unitOFWork;
            private UnitOFWork unitOWork;

            public CategoryController(UnitOFWork unitofWork)
            {
                unitOWork = unitofWork;

            }
            public IActionResult Index()
            {
                return View();
            }
            public IActionResult Upsert(int? id) // action method for uppsert
            {
                Category category = new Category();
                if (id == null)
                {
                    return View(category);

                }
                category = unitOWork.Category.Get(id.GetValueOrDefault());
                if (category == null)
                {
                    return NotFound();
                }
                return View(category);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]

            public IActionResult Upsert(Category category)
            {
                if (ModelState.IsValid)
                {
                    if (category.Id == 0)
                    {
                        unitOWork.Category.Add(category);
                        unitOWork.Save();
                    }
                    else
                    {
                        unitOWork.Category.Update(category);
                    }
                    unitOFWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(category);
            }
            #region API CALLS
            [HttpGet]
            public IActionResult GetAll()
            {
                var allObj = unitOWork.Category.GetAll();
                return Json(new { data = allObj });
            }
            [HttpGet]

            public IActionResult GetALL()
            {
                var allObj = unitOWork.Category.GetAll();
                return Json(new { data = allObj });
            }


            [HttpDelete]

            public IActionResult Delete(int id)
            {
                var objFromDb = unitOWork.Category.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting" });
                }
                unitOWork.Category.Remove(objFromDb);
                unitOWork.Save();
                return Json(new { success = true, message = "Delete successful" });
            }
            #endregion
        }
    }