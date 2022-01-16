using DevTranslate.Api.Attributes;
using DevTranslate.Api.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace DevTranslate.Api.Controllers
{
    [ApiController]
    [Route("rss")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class RssController : ControllerBase
    {
        private readonly DevTranslateContext _context;

        public RssController(DevTranslateContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        [ResponseCache(Duration = 7200)]
        [OutputCache("RssFeedResult")]
        public IActionResult Index()
        {
            SyndicationFeed feed = new("DevTranslate", null, new Uri("https://devtranslate.io/"), "https://api.devtranslate.io/rss", DateTime.UtcNow);

            feed.Items = _context.Translations
                .ToList()
                .Select(t =>
                {
                    var item = new SyndicationItem(t.Title, null, new Uri(t.Url));
                    item.Categories.Add(new SyndicationCategory(t.Type.ToString()));
                    return item;
                })
                .ToList();

            var settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                NewLineHandling = NewLineHandling.Entitize,
                NewLineOnAttributes = true,
                Indent = true
            };

            using var stream = new MemoryStream();
            using var xmlWriter = XmlWriter.Create(stream, settings);

            var rssFormatter = new Rss20FeedFormatter(feed, false);
            rssFormatter.WriteTo(xmlWriter);
            xmlWriter.Flush();
            
            return File(stream.ToArray(), "application/rss+xml; charset=utf-8");
        }
    }
}
