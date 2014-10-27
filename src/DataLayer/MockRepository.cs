namespace DataLayer
{
    using System;
    using System.Collections.Generic;

    using Model;

    public class MockRepository : INewsRepository
    {
        public IEnumerable<NewsEntry> GetNews()
        {
            yield return new NewsEntry { Rank = 1, Title = "News 1", Date = DateTime.Now.AddYears(-1) };
            yield return new NewsEntry { Rank = 2, Title = "News 2", Date = DateTime.Now };
            yield return new NewsEntry { Rank = 3, Title = "News 3", Date = DateTime.Now.AddYears(-3) };
        }
    }
}
