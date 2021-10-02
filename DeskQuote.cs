﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Stratford
{
    public enum ShippingType
    {
        Rush3Day,
        Rush5Day,
        Rush7Day,
        NoRush
    }

    class DeskQuote
    {
        public DateTime QuoteDate { get; set; }
        
        public string CustomerName { get; set; }

        public decimal QuoteAmount { get; set; }

        public ShippingType Shipping { get; set; }
    }
}
