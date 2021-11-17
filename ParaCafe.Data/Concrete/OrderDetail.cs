//SiparisDetay
//* UrunAd: string
//* BirimFiyat: decimal
//* Adet: int
//* TutarTL: string -readonly
//-Tutar(): decimal


namespace ParaCafe.Data.Concrete
{
    public class OrderDetail
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string TotalPrice { get { return $"{Tutar():n2}₺"; } }

        public decimal Tutar()
        {
            return UnitPrice * ProductQuantity;
        }

    }
}
