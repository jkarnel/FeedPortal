using FeedPortal.Core.Entities;
using FeedPortal.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedPortal.Core.Services.Concrete
{
    public class RssFeedReader : IFeedReader
    {
        public List<FeedItem> GetAllFeeds(FeedSource source)
        {
            throw new NotImplementedException();
        }
    }
}
