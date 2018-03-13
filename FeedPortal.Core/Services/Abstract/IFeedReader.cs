using FeedPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Services.Abstract
{
    public interface IFeedReader
    {
        List<FeedItem> GetAllFeeds(FeedSource source);
    }
}
