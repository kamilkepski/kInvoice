using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kInvoice.Models
{
    class Invoice
    {
        public string Id { get; set; }
        public string City { get; set; }
        public DateTimeOffset? IssueDate { get; set; }
        public DateTimeOffset? SaleDate { get; set; }
        public string PaymentDueDate { get; set; }
        public string PaymentMethod { get; set; }
    }
}
