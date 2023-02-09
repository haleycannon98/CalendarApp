using Microsoft.EntityFrameworkCore;

namespace CalendarAPI.Context
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions options) : base(options) { }

        //public DbSet<Calendar> Calendars { get; set; }
        public DbSet<CalendarEvent> Events { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Stickers> Stickers { get; set; }
        public DbSet<StickyNotes> StickyNotes { get; set; }

        
    }
}
