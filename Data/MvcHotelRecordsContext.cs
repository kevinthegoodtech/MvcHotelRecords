using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcHotelRecords.Models;

namespace MvcHotelRecords.Data
{
    public class MvcHotelRecordsContext : DbContext
    {
        public MvcHotelRecordsContext (DbContextOptions<MvcHotelRecordsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcHotelRecords.Models.Listing> Listing { get; set; } = default!;
    }
}
