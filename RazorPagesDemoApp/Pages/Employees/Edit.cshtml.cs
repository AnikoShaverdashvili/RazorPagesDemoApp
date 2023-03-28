using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemoApp.Data;
using RazorPagesDemoApp.Models.ViewModels;

namespace RazorPagesDemoApp.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesDemoDbContext _dbContext;

        [BindProperty]
        public EditEmployeeViewModel EditEmployeeViewModel { get; set; }

        public EditModel(RazorPagesDemoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnGet(Guid id)
        {
            var employee = _dbContext.Employees.Find(id);
            if (employee != null)
            {
                EditEmployeeViewModel = new EditEmployeeViewModel()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Email = employee.Email,
                    Salary = employee.Salary,
                    DateOfBirth = employee.DateOfBirth,
                    Department = employee.Department
                };
            }
        }
        public void OnPostUpdate()
        {
            if (EditEmployeeViewModel != null)
            {
                var existingEmployee = _dbContext.Employees.Find(EditEmployeeViewModel.Id);
                if (existingEmployee != null)
                {
                    existingEmployee.Name = EditEmployeeViewModel.Name;
                    existingEmployee.Email = EditEmployeeViewModel.Email;
                    existingEmployee.Salary = EditEmployeeViewModel.Salary;
                    existingEmployee.DateOfBirth = EditEmployeeViewModel.DateOfBirth;
                    existingEmployee.Department = EditEmployeeViewModel.Department;

                    _dbContext.SaveChanges();

                    ViewData["Message"] = "Employee updated successfully!";
                }
            }
        }


        public IActionResult OnPostDelete()
        {
            var existingEmployee = _dbContext.Employees.Find(EditEmployeeViewModel.Id);
            if(existingEmployee != null)
            {
                _dbContext.Employees.Remove(existingEmployee);
                _dbContext.SaveChanges();
                return RedirectToPage("/Employees/List");


            }
            return Page();


        }
    }
}
