namespace BusinessLayer
{
    using System.Collections.Generic;

    using Model;

    public interface INewsService
    {
        IEnumerable<NewsEntry> GetNews();
    }
}
