using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab_80_ASP_Core_Web.Models;

namespace lab_80_ASP_Core_Web.Pages
{
    public class EmployeesModel : PageModel
    {
        public List<Employee> EmpList = new List<Employee>();
        public void OnGet()
        {
            using (var db = new Northwind())
            {

                EmpList = db.Employees.ToList();
            }
        }
    }
}