using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauService
{
    public class PaymentService
    {
        PaymentDao PaymentDao;

        public PaymentService()
        {
            PaymentDao = new PaymentDao();
        }
        public void PaymentHistory(Payment payment)
        { 
        PaymentDao.PaymentHistory(payment);
        }
        public List<Payment> GetPayment()
        {
            List<Payment> payments = PaymentDao.GetPayment();
            return payments;
        }
    }
}
