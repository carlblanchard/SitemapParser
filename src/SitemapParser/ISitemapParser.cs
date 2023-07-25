using System;

namespace SitemapParser
{
    public interface ISitemapParser
    {
        Sitemap Parse(string sitemapData, Uri sitemapLocation = null);
    }
}
