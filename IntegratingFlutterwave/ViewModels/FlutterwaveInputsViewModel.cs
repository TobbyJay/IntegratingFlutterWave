using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratingFlutterwave.ViewModels
{
    public class FlutterwaveInputsViewModel
    {
        public string currency { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public decimal amount { get; set; }
        public string tx_ref { get; set; }

    }
}
