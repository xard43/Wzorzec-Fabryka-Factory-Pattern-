using System;
using System.Collections.Generic;
using System.Text;

namespace Wzorzec_fabryka
{
    public class BankOne : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            // Metoda to pozwala na dokonanie płatności za pomocą pierwszego sposobu
            Console.WriteLine("Pierwszy rodzaj płatności za {0}, kwota {1}", product.Name, product.Price);
        }
    }
    public class BankTwo : IPaymentGateway
    {
        public void MakePayment(Product product)
        {
            // Metoda to pozwala na dokonanie płatności za pomocą drugiego sposobu
            Console.WriteLine("Drugi rodzaj płatności za {0}, kwota {1}", product.Name, product.Price);
        }
    }
}
