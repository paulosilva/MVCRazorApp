using System;
using System.Data.Entity;

namespace MVCRazorApp.Models
{

	public class Movie
	{
		public int ID { get; set; }
		public string Title { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Genre { get; set; }
		public decimal Price { get; set; }

	}

	public partial class MovieDBContext : DbContext
	{
		public MovieDBContext() : base(nameOrConnectionString: "MyDatabaseContext") { }

		public DbSet<Movie> Movies { get; set; }

	}


}


