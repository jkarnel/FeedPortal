using FeedPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Services.Abstract
{
    public interface IFeedSorceProvider
    {
        List<Feed> GetAllFeeds(FeedSource source);
    }
}
