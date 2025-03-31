using Webshop.Core.Models;

namespace Webshop.Core.Repositories
{
    public interface IReceiptRepository
    {
        public ICollection<Receipt> GetReceipts();
    }
}
