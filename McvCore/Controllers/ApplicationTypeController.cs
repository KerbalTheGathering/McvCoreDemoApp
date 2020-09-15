using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using McvCore.Data;
using McvCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace McvCore.Controllers
{
	public class ApplicationTypeController : Controller
	{
		private readonly ApplicationDbContext _db;

		public ApplicationTypeController(ApplicationDbContext db)
		{
			_db = db;
		}

		//GET - CREATE
		public IActionResult Create()
		{
			return View();
		}

		//POST - CREATE
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ApplicationTypeModel obj)
		{
			if (ModelState.IsValid)
			{
				_db.ApplicationTypes.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(obj);
		}

		//GET - DELETE
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
				return NotFound();
			var obj = _db.ApplicationTypes.Find(id);
			if (obj == null)
				return NotFound();

			return View(obj);
		}

		//POST - DELETE
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{
			var obj = _db.ApplicationTypes.Find(id);
			if (obj == null)
				return NotFound();
			_db.ApplicationTypes.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		//GET - EDIT
		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
				return NotFound();
			var obj = _db.ApplicationTypes.Find(id);
			if (obj == null)
				return NotFound();
			return View(obj);
		}

		//POST - EDIT
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(ApplicationTypeModel obj)
		{
			if (ModelState.IsValid)
			{
				_db.ApplicationTypes.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(obj);
		}

		public IActionResult Index()
		{
			IEnumerable<ApplicationTypeModel> objList = _db.ApplicationTypes;
			return View(objList);
		}
	}
}