namespace BusinessLayer
{
    using System.Collections.Generic;
    using System.Linq;

    using DataLayer;

    using Model;

    public class SortByDateService : INewsService
    {
        private readonly INewsRepository newsRepository;

        public SortByDateService(INewsRepository newsRepository)
        {
            this.newsRepository = newsRepository;
        }
        
        public IEnumerable<NewsEntry> GetNews()
        {
            return this.newsRepository.GetNews().OrderByDescending(entry => entry.Date);
        }
    }
}
