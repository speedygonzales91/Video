using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public static List<Customer> customerList = new List<Customer>()
            {
                new Customer() {Id = 0, Name = "John Smith"},
                new Customer() {Id = 1, Name="Mary Williams"}
            };
        public static  Movie movie = new Movie() { Id = 0, Name = "Shrek" };

        RandomMovieViewModel randomMovie = new RandomMovieViewModel() { Movie = movie, Customers = customerList };

        // GET: Customers
        public ActionResult Index()
        {
            return View(randomMovie);
        }

        public ActionResult Details(int id)
        {
            for (int i = 0; i < randomMovie.Customers.Count; i++)
            {
                if (id == i)
                {

                }
            }
        }
    }
}