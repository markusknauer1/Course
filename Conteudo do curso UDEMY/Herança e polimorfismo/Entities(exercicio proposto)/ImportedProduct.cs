using System.Globalization;

namespace Course.Entities
{
    class ImportedProduct : Product
    {
        public double Customsfee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsfee)
            : base(name, price)
        {
            Customsfee = customsfee;
        }
        public  double TotalPrice()
        {
            return Price + Customsfee;
        }

        public override string PriceTag()
        {
            return Name
                + " R$"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs fee: R$"
                + Customsfee.ToString("F2", CultureInfo.InvariantCulture)
                + " )";
        }
    }
}
