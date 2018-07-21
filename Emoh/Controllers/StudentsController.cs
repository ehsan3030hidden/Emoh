using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Emoh.Controllers
{
    [Authorize]
    public class StudentsController : Controller
    {
        private readonly Models.Interfaces.IStudentRepository _repo;
        public StudentsController(Models.Interfaces.IStudentRepository repo) => _repo = repo;

        public IActionResult Index() => View(_repo.GetAll().Reverse());

        public IActionResult Delete(int id) => View(_repo.GetById(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(_repo.GetById(id));
            return RedirectToAction("Index");
        }

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.Student student)
        {
            _repo.Create(student);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id) => View(_repo.GetById(id));

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Models.Student student)
        {
            _repo.Update(student);
            return RedirectToAction("Index");
        }
    }
}