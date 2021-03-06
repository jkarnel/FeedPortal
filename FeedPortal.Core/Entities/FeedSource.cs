﻿using System;
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

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string Url { get; private set; }
        public FeedSourceType Type { get; private set; }
    }
}
