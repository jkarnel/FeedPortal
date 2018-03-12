using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Entities
{
    public class FeedSource
    {
        public FeedSource(string url, FeedSourceType type)
        {
            Url = url;
            Type = type;
        }

        public string Url { get; private set; }
        public FeedSourceType Type { get; private set; }
    }
}
