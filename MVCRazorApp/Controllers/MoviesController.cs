using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data; 
using System.Data.Entity; 
using System.Net; 

using MVCRazorApp.Models; 

namespace MVCRazorApp.Controllers
{

    public class MoviesController : Controller
    {

		private MovieDBContext db = new MovieDBContext(); 

		// GET: /Movies/ 
		public ActionResult Index() 
		{ 
			return View(db.Movies.ToList()); 
		} 

		// GET: /Movies/Details/5 
		public ActionResult Details(int? id) 
		{ 
			if (id == null) 
			{ 
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
			} 
			Movie movie = db.Movies.Find(id); 
			if (movie == null) 
			{ 
				return HttpNotFound(); 
			} 
			return View(movie); 
		} 

		// GET: /Movies/Create 
		public ActionResult Create() 
		{ 
			return View(); 
		} 

		// POST: /Movies/Create 
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for  
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598. 
		[HttpPost] 
		[ValidateAntiForgeryToken] 
		public ActionResult Create([Bind(Include="Title,ReleaseDate,Genre,Price")] Movie movie) 
		// "ID,Title,ReleaseDate,Genre,Price"
		{ 
			if (ModelState.IsValid) 
			{ 
				db.Movies.Add(movie); 

				// Test debug on Mac
				db.SaveChanges(); 
				return RedirectToAction("Index"); 
			} 

			return View(movie); 
		} 

		// GET: /Movies/Edit/5 
		public ActionResult Edit(int? id) 
		{ 
			if (id == null) 
			{ 
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
			} 
			Movie movie = db.Movies.Find(id); 
			if (movie == null) 
			{ 
				return HttpNotFound(); 
			} 
			return View(movie); 
		} 

		// POST: /Movies/Edit/5 
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for  
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598. 
		[HttpPost] 
		[ValidateAntiForgeryToken] 
		public ActionResult Edit([Bind(Include="ID,Title,ReleaseDate,Genre,Price")] Movie movie) 
		{ 
			if (ModelState.IsValid) 
			{ 
				db.Entry(movie).State = EntityState.Modified; 
				db.SaveChanges(); 
				return RedirectToAction("Index"); 
			} 
			return View(movie); 
		} 

		// GET: /Movies/Delete/5 
		public ActionResult Delete(int? id) 
		{ 
			if (id == null) 
			{ 
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
			} 
			Movie movie = db.Movies.Find(id); 
			if (movie == null) 
			{ 
				return HttpNotFound(); 
			} 
			return View(movie); 
		} 

		// POST: /Movies/Delete/5 
		[HttpPost, ActionName("Delete")] 
		[ValidateAntiForgeryToken] 
		public ActionResult DeleteConfirmed(int id) 
		{ 
			Movie movie = db.Movies.Find(id); 
			db.Movies.Remove(movie); 
			db.SaveChanges(); 
			return RedirectToAction("Index"); 
		} 

		protected override void Dispose(bool disposing) 
		{ 
			if (disposing) 
			{ 
				db.Dispose(); 
			} 
			base.Dispose(disposing); 
		} 

    }
}
