using System;
using System.Threading.Tasks;

namespace SitemapParser
{
    public interface ISitemapFetcher
    {
        Task<string> Fetch(Uri sitemapLocation);
    }
}
