using System;

namespace FeedTranslator
{
    public class FeedTranslator
    {
        private string request;
        private UriBuilder uri;

        public FeedTranslator(string request)
        {
            this.request = request;
            this.uri = new UriBuilder(this.request);
        }

        public string Feed()
        {
          return this.ReplaceScheme(this.uri, "feed");
        }

        public string Itpc()
        {
            return this.ReplaceScheme(this.uri, "itpc");
        }

        public string Podcast()
        {
            return this.ReplaceScheme(this.uri, "podcast");
        }

        private string ReplaceScheme(UriBuilder uri, string scheme)
        {
            if (uri.Uri.IsDefaultPort)
            {
                uri.Port = -1;
            }

            uri.Scheme = scheme;
            return uri.ToString();
        }
    }
}
