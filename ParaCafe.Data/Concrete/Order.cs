//Siparis
//* MasaNo: int
//* Durum: SiparisDurum
//* OdenenTutar: decimal
//* AcilisZamani: DateTime?
//* KapanisZamani: DateTime?
//* SiparisDetaylar: List<SiparisDetay>
//* ToplamTutarTL: string -readonly
//-ToplamTutar(): decimal

using ParaCafe.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParaCafe.Data.Concrete
{
    public class Order
    {
        public int TableNo { get; set; }
        public OrderStatus Status { get; set; }
        public decimal PaidPrice { get; set; }
        public DateTime? OpenTime { get; set; } = DateTime.Now;
        public DateTime? CloseTime { get; set; }
        public List<OrderDetail> OrderDetail { get; set; } = new List<OrderDetail>();
        public string TotalPrice { get { return $"{GetTotalPrice():n2}₺"; } }

        public decimal GetTotalPrice()
        {
            return OrderDetail.Sum(x => x.Tutar());
        }

    }
}
