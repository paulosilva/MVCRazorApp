using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

using MVCRazorApp.Models;

namespace MVCRazorApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			/**
			using (var _context = new MovieDBContext())
			{

				try {
					
					// Create Record
//					_context.Movies.Add(new Movie () {
//						Title = "Title 1 Of : " + DateTime.Now.ToString(),
//						ReleaseDate = DateTime.Now,
//						Genre = "Generic Genre",
//						Price = 1.0m
//					});
					_context.Movies.Add(new Movie () {
						Title = "Title 1 Of : " + DateTime.Now.ToString(),
						ReleaseDate = DateTime.Now,
						Genre = "Generic Genre",
						Price = 2.0m
					});
					_context.SaveChanges();

//					// Read Record
//					Movie _m_movie = _context.Movies.Find(1);
//					Console.WriteLine(_m_movie.ToString());
//					Console.WriteLine(_m_movie.Title);
//
//					// Update Record
//					_m_movie.Title = "New Title ...";
//					_context.SaveChanges();
//
//					// Delete Record
//					int _m_max = _context.Movies.Max(m => m.ID);
//					Movie _d_movie = _context.Movies.Find(_m_max);
//					_context.Movies.Remove(_d_movie);
//					_context.SaveChanges();
//
//					// Read (all) Records
//					var _movies = _context.Movies.ToList();
//					foreach (var _movie in _movies)
//					{
//						Console.WriteLine(_movie.ID + " - " + _movie.Title);
//					}

				} catch (Exception ex) {
				
					Console.WriteLine (ex.Message);

				}

			}
			**/

			var mvcName = typeof(Controller).Assembly.GetName ();
			var isMono = Type.GetType ("Mono.Runtime") != null;

			ViewData ["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData ["Runtime"] = isMono ? "Mono" : ".NET";

			return View ();
		}
	}
}

