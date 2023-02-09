using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
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
        public int CalId { get; set; }
        [ForeignKey("CalId")]
        public virtual Calendar Calendar { get; set; }


    }
}
