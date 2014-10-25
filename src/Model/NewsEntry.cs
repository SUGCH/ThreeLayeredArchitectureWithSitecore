namespace Model
{
    using System;

    public class NewsEntry
    {
        public int Rank { get; set; }
        
        public virtual string Title { get; set; }

        public virtual DateTime Date { get; set; }
    }
}
