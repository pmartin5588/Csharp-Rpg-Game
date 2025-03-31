using System.Data;
using Webshop.Core.Models;
using Webshop.Core.Repositories;

namespace Webshop.Infrastructure.Repositories
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly IDbConnection _connection;

        public ReceiptRepository(IDbConnection dbConnection)
        {
            _connection = dbConnection;
        }

        public ICollection<Receipt> GetReceipts()
        {
            //_connection.Open();
            //_connection.CreateCommand();
            //_connection.Close();

            return new List<Receipt> { new Receipt() };
        }
    }
}
