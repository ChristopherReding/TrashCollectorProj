using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee
        public IActionResult Index()
        {            
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
                DateTime dt = DateTime.Now;
                var customerList = _context.Customers.Where(c => c.WeeklyPickupDay == dt.DayOfWeek.ToString() && c.ZipCode == employee.ZipCode).ToList();
                foreach(var item in _context.Customers.Where(c => c.OneTimePickup == dt.Date))
                {
                    customerList.Add(item);
                }
                foreach(var item in _context.Customers.Where(c => c.StartServiceHold < dt.Date && c.EndServiceHold > dt.Date))
                {
                    customerList.Remove(item);
                }
                var employeeCustomerViewModel = new EmployeeCustomerViewModel(employee, customerList);
                return View(employeeCustomerViewModel);

            }
            catch
            {
                return RedirectToAction("Create");
            }            
            
        }
        //[HttpPost]
        //public IActionResult Index(Employee employee)
        //{
        //    DateTime dt = DateTime.Now;
        //    var customerList = _context.Customers.Where(c => c.WeeklyPickupDay == (dt.DayOfWeek).ToString() && c.ZipCode == employee.ZipCode);
        //    return View(customerList);
        //}

        // Get: Day of Week details
        public IActionResult DailyDetails(string dayOfWeek)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            try
            {
                var employee = _context.Employees.Where(e => e.IdentityUserId == userId).SingleOrDefault();
                var customerList = _context.Customers.Where(c => c.WeeklyPickupDay == dayOfWeek && c.ZipCode == employee.ZipCode).ToList();
                var employeeCustomerViewModel = new EmployeeCustomerViewModel(employee, customerList);
                return View(employeeCustomerViewModel);
            }
            catch
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpGet]
        public IActionResult ConfirmPickup(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = _context.Customers.Where(c => c.Id == id).SingleOrDefault();
            return View(customer);
        }
        [HttpPost]
        public IActionResult ConfirmPickup(Customer customer)
        {            
            customer.AccountBalance = customer.AccountBalance + 5.00;
            _context.Update(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Employee/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = _context.Customers.Where(m => m.Id == id).FirstOrDefault();
            return View(customer);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            var employee = new Employee();
            return View(employee);
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                employee.IdentityUserId = userId;
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(employee);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,FirstName,LastName,ZipCode,IdentityUserId")] Employee employee)
        {
            if (id != employee.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.id == id);
        }
    }
}
