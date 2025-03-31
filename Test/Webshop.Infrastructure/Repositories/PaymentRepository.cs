using System.Data;
using Webshop.Core.Models;
using Webshop.Core.Repositories;

namespace Webshop.Infrastructure.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IDbConnection _connection;

        public PaymentRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public ICollection<Payment> GetPayments()
        {
            //_connection.Open();
            //_connection.CreateCommand();
            
            //_connection.Close();

            return new List<Payment>{new Payment()};
        }
    }
}
