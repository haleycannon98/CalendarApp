using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalendarAPI
{
    public class CalendarEvent
    {
        //add location var later
        //maybe add flags for custom repeat

        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool AllDay { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int RepeatNum { get; set; }
        public enum Repeat { None, Daily, Weekly, Monthly, Yearly };
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual IdentityUser User { get; set; }


    }
}
