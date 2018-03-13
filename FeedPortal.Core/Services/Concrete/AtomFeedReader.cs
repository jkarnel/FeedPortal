using FeedPortal.Core.Entities;
using FeedPortal.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Services.Concrete
{
    public class AtomFeedReader : IFeedReader
    {
        public List<FeedItem> GetAllFeeds(FeedSource source)
        {
            throw new NotImplementedException();
        }
    }
}
