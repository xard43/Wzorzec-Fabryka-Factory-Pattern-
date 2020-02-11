using System;
using System.Collections.Generic;
using System.Text;
using static Wzorzec_fabryka.PaymentMethod;

namespace Wzorzec_fabryka
{
    public class PaymentProcessor
    {
        IPaymentGateway gateway = null;
        // Dokonywanie płatności
        // Wywołanie metody CreatePaymentGateway(...) zwraca nam obiekt utworzony
        // w zależności od wyboru rodzaju płatności przez klienta
        public void MakePayment(EPaymentMethod method, Product product)
        {
            PaymentGatewayFactory2 factory = new PaymentGatewayFactory2();
            this.gateway = factory.CreatePaymentGateway(method, product);
            // w przkładzie, który został przygotowany nie została przygotowana metoda do "obsługi"
            
            this.gateway.MakePayment(product);
        }
    }
}
