using Cinema.Domain.Entities;
using Cinema.Web.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.Collect
{
    public class InvoicesCollect
    {
        public static void Collect(ExcelWorksheet rawData, ApplicationDbContext context)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Invoice invoice = new Invoice
                {
                    Reservation = context.Reservations.Find(rawData.ReadInteger(row, 2)),
                    OfferType = context.Pricing.Find(rawData.ReadInteger(row, 3)),
                    Price = rawData.ReadDecimal(row, 4),
                    TaxAmount = rawData.ReadDecimal(row, 5),
                    TicketQuantity = rawData.ReadInteger(row, 6)
                };

                context.Add(invoice);
                context.SaveChanges();
            }
        }
    }
}
