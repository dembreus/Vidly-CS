﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer 1" },
                new Customer{ Name = "Customer 2" }
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };
            return View(viewModel);
        }
    }
}