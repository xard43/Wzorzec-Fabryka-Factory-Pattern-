using System;
using static Wzorzec_fabryka.PaymentMethod;

namespace Wzorzec_fabryka
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie instancji klasy w której znajduje się metoda do dokonania płatności
            PaymentProcessor pre = new PaymentProcessor();
            // Definiujemy produkt - to jest tylko przykład
            Product prod = new Product();
            prod.Name = "Audi RS6";
            prod.Price = (double)560000;
            prod.Description = "Bardzo szybkie rodzinne kombi";
            // Dokonujemy płatności pierszym sposobem.
            pre.MakePayment(EPaymentMethod.PAYPAL, prod);
            Console.ReadKey();
            // Wynik działania programu
            // Pierwszy rodzaj platnosci za Audi RS6, kwota 560000
        }


    }
}
