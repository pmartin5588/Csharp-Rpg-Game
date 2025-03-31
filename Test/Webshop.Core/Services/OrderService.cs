using Webshop.Core.Repositories;

namespace Webshop.Core.Services
{
    public class OrderService : IOrderService
    {
        private IPaymentRepository _paymentRepository;
        private IReceiptRepository _receiptRepository;

        public OrderService(
            IPaymentRepository paymentRepository, IReceiptRepository receiptRepository)
        {
            _paymentRepository = paymentRepository;
            _receiptRepository = receiptRepository;
        }

        public bool Reconcile()
        {
            var payments = _paymentRepository.GetPayments();
            var receipts = _receiptRepository.GetReceipts();

            var counter = 0;
            foreach (var payment in payments)
            {
                foreach (var receipt in receipts)
                {
                    if(payment.TransactionsId == receipt.Id)
                        counter++;
                }
            }

            if (counter != receipts.Count)
            {
                return false;
            }

            return true;
        }
    }
}
