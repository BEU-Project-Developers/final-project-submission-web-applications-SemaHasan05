using Grocery_shop_web.Models.Enums;

namespace Grocery_shop_web.Models.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public PStatus PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TransactionId { get; set; }

        public Order Order { get; set; }
    }

}
