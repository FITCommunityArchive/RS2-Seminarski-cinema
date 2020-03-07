using Cinema.Domain.Entities;
using Cinema.DAL.Data;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Seed.CollectMethods
{
    public class InvoicesCollect
    {
        public static void Collect(ExcelWorksheet rawData, UnitOfWork unit)
        {
            for (int row = 2; row <= rawData.Dimension.Rows; row++)
            {
                Invoice invoice = new Invoice
                {
                    Reservation = unit.Reservations.Get(rawData.ReadInteger(row, 2)),
                    OfferType = unit.Pricings.Get(rawData.ReadInteger(row, 3)),
                    Price = rawData.ReadDecimal(row, 4),
                    TaxAmount = rawData.ReadDecimal(row, 5),
                    TicketQuantity = rawData.ReadInteger(row, 6)
                };

                unit.Invoices.Insert(invoice);
                unit.Save();
                Console.WriteLine($"Inserted invoice nr. ${row}");
            }
        }
    }
}
