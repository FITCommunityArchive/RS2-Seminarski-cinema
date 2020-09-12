namespace Cinema.Common.Interfaces.Integrations
{
    public interface IQRCodeService
    {
        string GenerateCode(string qrText, bool includeImage = true);
    }
}
