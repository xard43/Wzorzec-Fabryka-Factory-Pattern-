using System;
using System.Collections.Generic;
using System.Text;
using static Wzorzec_fabryka.PaymentMethod;
using static Wzorzec_fabryka.Program;

namespace Wzorzec_fabryka
{
    
    public class PaymentGatewayFactory
    {
        public virtual IPaymentGateway CreatePaymentGateway(EPaymentMethod method, Product prod)
        {
            IPaymentGateway gateway = null;
            switch (method)
            {
                case EPaymentMethod.BANK_ONE:
                    gateway = new BankOne();
                    break;
                case EPaymentMethod.BANK_TWO:
                    gateway = new BankTwo();
                    break;
                default:
                    break;
            }
            return gateway;
        }
    }
}
