using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IFbackend.Models
{
    public partial class News
    {
        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("urlToImage")]
        public Uri UrlToImage { get; set; }

        [JsonProperty("publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("id")]
        public Id? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum Id { AbcNews, BusinessInsider, TheVerge, Time, Wired };

    
}

