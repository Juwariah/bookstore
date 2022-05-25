﻿using BookingService.Models;
using Microsoft.EntityFrameworkCore;
namespace BookingService.Data
{
    public class BookingContext:DbContext
        
        {
            public BookingContext(DbContextOptions<BookingContext> options) : base(options)
            {
            }
            public DbSet<BookingServiceItem> BookingServiceItem { get; set; }
        }
    
}
