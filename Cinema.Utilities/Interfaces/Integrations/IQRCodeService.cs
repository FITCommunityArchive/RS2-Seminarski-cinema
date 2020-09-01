using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Utilities.Interfaces.Integrations
{
    public interface IQRCodeService
    {
        string GenerateCode(string qrText, bool includeImage = true);
    }
}
