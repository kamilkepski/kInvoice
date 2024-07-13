using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kInvoice.Models
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCodeCity { get; set; }
        public string NIP { get; set; }
    }
}
