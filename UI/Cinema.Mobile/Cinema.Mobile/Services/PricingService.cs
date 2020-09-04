using Cinema.Shared.Constants;

namespace Cinema.Mobile.Services
{
    public class PricingService
    {
        public decimal CalculateVatAmount(decimal priceWithoutVat)
        {
            decimal vatAmount = priceWithoutVat * Vat.VAT_PERCENTAGE;
            return vatAmount;
        }

        public decimal CalculateTotalWithVatAmount(decimal priceWithoutVat)
        {
            decimal vatAmount = CalculateVatAmount(priceWithoutVat);
            return priceWithoutVat + vatAmount;
        }

        public string GetTotalWithVatAmount(decimal priceWithoutVat)
        {
            decimal total = CalculateTotalWithVatAmount(priceWithoutVat);
            return total.ToString("F2");
        }
    }
}
