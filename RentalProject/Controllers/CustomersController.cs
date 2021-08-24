using RentalProject.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalProject.Controllers
{
    public class CustomersController : Controller
    {
        private DBContext _context;
        public CustomersController()
        {
            _context = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customer);
        }
        public ActionResult Detail(int Id)
        {

            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Id = 1,Name = "Ramji Kasuddin"},
        //        new Customer {Id = 2,Name = "Yuvraj"}
        //    };
        //}
    }
}