//KafeVeri
//* MasaAdet: int
//* Urunler: List<Urun>
//* AktifSiparisler: List<Siparis>
//* GecmisSiparisler: List < Siparis >


using System.Collections.Generic;

namespace ParaCafe.Data.Concrete
{
    public class CafeData
    {
        public int TableQuantity { get; set; } = 20;
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Order> ActiveOrders { get; set; } = new List<Order>();
        public List<Order> PastOrders { get; set; } = new List<Order>();

    }
}
