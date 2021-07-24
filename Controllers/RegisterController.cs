using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CJSTUFF.Data;
using CJSTUFF.Models;

namespace CJSTUFF.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RegisterController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Register record)
        {
            var register = new Register();
            register.FirstName = record.FirstName;
            register.LastName = record.LastName;
            register.Email = record.Email;
            register.Username = record.Username;
            register.Password = record.Password;
            register.ContactNo = record.ContactNo;
            register.Address = record.Address;
            register.DateAdded = DateTime.Now;
            _context.Registers.Add(register);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Faqs()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }

    }
}