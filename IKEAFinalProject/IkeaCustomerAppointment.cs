﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEAFinalProject
{
    public class IkeaCustomerAppointment
    {
        public IkeaCustomer customerIkea { get; set; }
        // 

        public IkeaPersonalShoppingAppointment appointmentShopping { get; set; }
        //

        public IkeaCustomerAppointment (IkeaCustomer i, IkeaPersonalShoppingAppointment ipsa)
        {
            customerIkea = i;
            // 
            appointmentShopping = ipsa;
            // 
        }



    }
}
