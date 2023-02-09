using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Stickers
    {
        public int Id { get; set; }
        public string? Color { get; set; }
        public string? Icon { get; set; }
        public DateTime Date { get; set; }
        public int CalId { get; set; }
        [ForeignKey("CalId")]
        public virtual Calendar Calendar { get; set; }
    }
}
