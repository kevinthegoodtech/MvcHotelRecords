using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcHotelRecords.Data;
using System;
using System.Linq;

namespace MvcHotelRecords.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcHotelRecordsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcHotelRecordsContext>>()))
            {
                // Look for any movies.
                if (context.Listing.Any())
                {
                    return;   // DB has been seeded
                }

                context.Listing.AddRange(
                    new Listing
                    {
                        FirstName = "John",
                        LastName = "Smith",
                        PhoneNumber = "999-888-7777",
                        CreditCardNumber = "000-000-000",
                        CheckInDate = DateTime.Parse("2010-1-12"),
                        CheckOutDate = DateTime.Parse("2010-2-12"),

                    },

                    new Listing
                    {
                        FirstName = "Kim",
                        LastName = "Doe",
                        PhoneNumber = "777-888-9999",
                        CreditCardNumber = "000-111-222",
                        CheckInDate = DateTime.Parse("2010-12-25"),
                        CheckOutDate = DateTime.Parse("2011-1-1"),

                    },

                    new Listing
                    {
                        FirstName = "John",
                        LastName = "Wick",
                        PhoneNumber = "404-202-8080",
                        CreditCardNumber = "020-020-020",
                        CheckInDate = DateTime.Parse("2016-5-8"),
                        CheckOutDate = DateTime.Parse("2016-5-9"),

                    }


                );
                context.SaveChanges();
            }
        }

    }
}
