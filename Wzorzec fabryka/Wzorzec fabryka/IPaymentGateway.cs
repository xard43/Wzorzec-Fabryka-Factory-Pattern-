using System;
using System.Collections.Generic;
using System.Text;

namespace Wzorzec_fabryka
{
    public interface IPaymentGateway
    {
        void MakePayment(Product product);
    }
}
