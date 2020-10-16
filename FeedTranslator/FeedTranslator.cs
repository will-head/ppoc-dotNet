using System;

namespace FeedTranslator
{
    public class FeedTranslator
    {
        private string request;

        public FeedTranslator(string request)
        {
            this.request = request;
        }

        public string Feed()
        {
            var uri = new UriBuilder(this.request);
            if (uri.Uri.IsDefaultPort)
            {
                uri.Port = -1;
            }

            uri.Scheme = "feed";
            return uri.ToString();
        }

        public string Itpc()
        {
            var uri = new UriBuilder(this.request);
            if (uri.Uri.IsDefaultPort)
            {
                uri.Port = -1;
            }

            uri.Scheme = "itpc";
            return uri.ToString();
        }
    }
}
