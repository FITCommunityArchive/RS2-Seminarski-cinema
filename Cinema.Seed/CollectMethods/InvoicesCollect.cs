using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Seed.CollectMethods
{
    public class InvoicesCollect
    {
        public static async Task Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Invoice invoice = new Invoice
                {
                    Reservation = await unit.Reservations.GetAsync(rawData.ReadInteger(row, 2)),
                    OfferType = await unit.Pricings.GetAsync(rawData.ReadInteger(row, 3)),
                    Price = rawData.ReadDecimal(row, 4),
                    TaxAmount = rawData.ReadDecimal(row, 5),
                    TicketQuantity = rawData.ReadInteger(row, 6)
                };

                await unit.Invoices.InsertAsync(invoice);                
                Console.WriteLine($"Inserted invoice nr. ${row}");
            }
            await unit.SaveAsync();
        }
    }
}
