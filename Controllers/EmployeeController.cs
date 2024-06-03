using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees
                .Include(e => e.LeaveApplications)
                    .ThenInclude(la => la.LeaveType)
                .ToListAsync();
            
            return View(employees);
        }
        [HttpGet]
        public IActionResult GetEmployeeById()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeId", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
        var employee = await _context.Employees
            .FirstOrDefaultAsync(e => e.EmployeeId == id);
        if (employee == null)
        {
                return NotFound();
        }
            return RedirectToAction("ViewEmployee", employee);
        }
        public async Task<IActionResult> ViewEmployee(Employee employee)
        {
            employee.LeaveApplications = await _context.LeaveApplications
                .Where(la => la.EmployeeId == employee.EmployeeId)
                .Include(la => la.LeaveType)
                .ToListAsync();
            return View(employee);
        }
    }
}
