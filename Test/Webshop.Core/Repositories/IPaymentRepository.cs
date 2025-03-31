using Webshop.Core.Models;

namespace Webshop.Core.Repositories
{
    public interface IPaymentRepository
    {
        public ICollection<Payment> GetPayments();
    }
}
