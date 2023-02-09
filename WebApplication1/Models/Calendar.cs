namespace WebApplication1.Models
{
    public class Calendar
    {
        public int Id { get; set; }
        private List<Notes>? CalNotes;
        private List<Stickers>? CalStickers;
        private List<StickyNotes>? CalStickyNotes { get; set; }

        private List<Notes> GetNotes()
        {
            return CalNotes;
        }

        private void SetNotes(Notes value)
        {
            CalNotes.Add(value);
        }

        private void AddNote(Notes value)
        {
            CalNotes.Add(value);
        }

        private List<Stickers> GetStickers()
        {
            return CalStickers;
        }

        private void SetStickers(List<Stickers> value)
        {
            CalStickers = value;
        }

        private void AddSticker(Stickers value)
        {
            CalStickers.Add(value);
        }


        private List<StickyNotes> GetStickyNotes()
        {
            return CalStickyNotes;
        }

        private void SetStickyNotes(List<StickyNotes> value)
        {
            CalStickyNotes = value;
        }

        private void AddStickyNotes(StickyNotes value)
        {
            CalStickyNotes.Add(value);
        }
        


    }

    public class Day
    {
    }
}
