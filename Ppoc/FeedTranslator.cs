using System;

namespace Ppoc
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

        public string Http()
        {
          return this.ReplaceScheme(this.uri, "http");
        }

        public string Https()
        {
          return this.ReplaceScheme(this.uri, "https");
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

        public string Downcast()
        {
            return this.ReplaceScheme(this.uri, "downcast");
        }

        public string Pcast()
        {
            return this.ReplaceScheme(this.uri, "pcast");
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
