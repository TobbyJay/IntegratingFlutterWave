using IntegratingFlutterwave.Models;
using IntegratingFlutterwave.Repo;
using IntegratingFlutterwave.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratingFlutterwave.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransactionRepo _transactionRepo;

        public HomeController(ILogger<HomeController> logger, ITransactionRepo transactionRepo)
        {
            _logger = logger;
            _transactionRepo = transactionRepo;
        }

        public IActionResult Index()
        {
            return View();
        }


        [Route("/api/Home/PayWithFlutterWave")]
        [HttpPost]
        public IActionResult PayWithFlutterwave(FlutterwaveInputsViewModel model)
        {
            if (ModelState.IsValid)
            {
                CreateTransactionDetail(model);
            }

            return Ok(model);
        }

        private Transaction CreateTransactionDetail(FlutterwaveInputsViewModel model)
        {
            var transactions = new Transaction
            {
                Amount = model.amount,
                CreatedAt = DateTime.UtcNow,
                CustomerEmail = model.email,
                CustomerName = model.name,
                TransactionReference = model.tx_ref,
                TransactionStatus = "Pending"
            };

            _transactionRepo.Create(transactions);

            return transactions;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
