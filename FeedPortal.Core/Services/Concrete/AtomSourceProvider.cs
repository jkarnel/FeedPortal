using FeedPortal.Core.Entities;
using FeedPortal.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Services.Concrete
{
    public class AtomSourceProvider : IFeedSorceProvider
    {
        public List<Feed> GetAllFeeds(FeedSource source)
        {
            throw new NotImplementedException();
        }
    }
}
