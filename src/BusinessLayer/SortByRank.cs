namespace BusinessLayer
{
    using System.Collections.Generic;
    using System.Linq;

    using DataLayer;

    using Model;

    public class SortByRank : INewsService
    {
        private readonly INewsRepository newsRepository;

        public SortByRank(INewsRepository newsRepository)
        {
            this.newsRepository = newsRepository;
        }
        
        public IEnumerable<NewsEntry> GetNews()
        {
            return this.newsRepository.GetNews().OrderBy(entry => entry.Rank);
        }
    }
}
