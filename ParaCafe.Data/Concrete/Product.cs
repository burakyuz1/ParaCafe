using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Urun
//* UrunAd: string
//* BirimFiyat: decimal
//-ToString(): string
namespace ParaCafe.Data.Concrete
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public override string ToString()
        {
            return $"{ProductName} - {UnitPrice:n2}₺";
        }
    }
}
