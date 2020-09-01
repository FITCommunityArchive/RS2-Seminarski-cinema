using Cinema.Shared.Constants;

namespace Cinema.Mobile.Services
{
    public class PricingService
    {
        public decimal CalculateVatAmount(decimal amountWithoutVat)
        {
            decimal vatAmount = amountWithoutVat * Vat.VAT_PERCENTAGE;
            return vatAmount;
        }

        public decimal CalculateTotalWithVatAmount(decimal amountWithoutVat)
        {
            decimal vatAmount = CalculateVatAmount(amountWithoutVat);
            return amountWithoutVat + vatAmount;
        }
    }
}
