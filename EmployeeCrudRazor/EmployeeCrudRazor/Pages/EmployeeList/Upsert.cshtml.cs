using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeCrudRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudRazor.Pages.EmployeeList
{
    public class UpsertModel : PageModel
    {
        private ApplicationDbContext _db;

        public UpsertModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            Employee = new Employee();
            if (id == null)
            {
                //create
                return Page();
            }

            //update
            Employee = await _db.Employee.FirstOrDefaultAsync(u => u.Id == id);
            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                if (Employee.Id == 0)
                {
                    _db.Employee.Add(Employee);
                }
                else
                {
                    _db.Employee.Update(Employee);
                }

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

    }
}