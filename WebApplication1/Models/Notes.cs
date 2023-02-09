using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public int CalId { get; set; }
        [ForeignKey("CalId")]
        public virtual Calendar Calendar { get; set; }
    }
}