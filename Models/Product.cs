using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kInvoice.Models
{
    class Product
    {
        public string Name { get; set; }
        public string MeasureUnit { get; set; }
        public int Amount { get; set; }
        public float PriceWithTax { get; set; }
        public int TaxRate { get; set; }

        public float PriceWithoutTax
        {
            get
            {
                return this.PriceWithTax / ((float)this.TaxRate / 100 + 1);
            }
        }

        public float PriceFinalWithoutTax
        {
            get
            {
                return this.Amount * this.PriceWithoutTax;
            }
        }

        public float Tax
        {
            get
            {
                return (this.TaxRate * this.PriceFinalWithoutTax) / 100;
            }
        }

        public float PriceFinal
        {
            get
            {
                return this.PriceFinalWithoutTax + this.Tax;
            }
        }
    }
}
