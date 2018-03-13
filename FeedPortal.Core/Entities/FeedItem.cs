using System;
using System.Collections.Generic;
using System.Text;

namespace FeedPortal.Core.Entities
{
    public class FeedItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public byte[] Image { get; set; }
        public DateTime PublicationDateTime { get; set; }
    }
}
