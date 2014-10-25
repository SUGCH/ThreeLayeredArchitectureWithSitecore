namespace DataLayer
{
    using System.Collections.Generic;
    using System.Linq;

    using Glass.Mapper.Sc;

    using Model;

    public class GlassRepository : INewsRepository
    {
        private readonly ISitecoreContext sitecoreContext;

        public GlassRepository(ISitecoreContext sitecoreContext)
        {
            this.sitecoreContext = sitecoreContext;
        }
        
        public IEnumerable<NewsEntry> GetNews()
        {
            return Enumerable.Empty<NewsEntry>();
        }
    }
}
