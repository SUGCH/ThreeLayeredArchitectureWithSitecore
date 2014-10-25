namespace DataLayer
{
    using System.Collections.Generic;

    using Model;

    public interface INewsRepository
    {
        IEnumerable<NewsEntry> GetNews();
    }
}
