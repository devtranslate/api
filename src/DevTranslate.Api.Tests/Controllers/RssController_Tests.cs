using DevTranslate.Api.Context;
using DevTranslate.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using Xunit;

namespace DevTranslate.Api.Tests.Controllers
{
    public class RssController_Tests
    {
        private readonly DevTranslateContext context;

        public RssController_Tests()
        {
            DbContextOptions<DevTranslateContext> options = new DbContextOptionsBuilder<DevTranslateContext>()
                .UseInMemoryDatabase(databaseName: "DevTranslateInMemoryDbForRss")
                .Options;

            context = new DevTranslateContext(options);

            if (!context.Translations.Any())
            {
                foreach (var translation in MockedData.All)
                {
                    context.Translations.Add(translation);
                }

                context.SaveChanges();
            }
        }

        [Fact]
        public void Should_ReturnHttpOk_When_RequestsRssFeed()
        {
            var controller = new RssController(context);

            var rssFeedResult = controller.GetRssFeedOfTranslations() as FileContentResult;

            Assert.NotNull(rssFeedResult);
            Assert.True(rssFeedResult.FileContents.Length > 0);
            Assert.True(rssFeedResult.ContentType == "application/rss+xml; charset=utf-8");
        }

        [Fact]
        public void Should_RenderAllTranslations_When_CreatingRssFeed()
        {
            var controller = new RssController(context);
            var rssFeedResult = controller.GetRssFeedOfTranslations() as FileContentResult;
            var feed = GetFeed(rssFeedResult.FileContents);

            int translationsOnDatabase = context.Translations.Count();
            int translationsOnXml = feed.Items.Count();

            Assert.Equal(translationsOnDatabase, translationsOnXml);
        }

        [Fact]
        public void Should_RenderFeedTitle_When_CreatingRssFeed()
        {
            var controller = new RssController(context);
            var rssFeedResult = controller.GetRssFeedOfTranslations() as FileContentResult;
            var feed = GetFeed(rssFeedResult.FileContents);

            Assert.True("DevTranslate".Equals(feed.Title.Text, System.StringComparison.CurrentCultureIgnoreCase));
        }

        [Fact]
        public void Should_RenderRssFeed_When_CreatingRssFeed()
        {
            var controller = new RssController(context);

            var rssFeedResult = controller.GetRssFeedOfTranslations() as FileContentResult;
            bool isRss = IsRssFeed(rssFeedResult.FileContents);

            Assert.True(isRss);
        }

        [Fact]
        public void Should_RenderLinkAndCategorias_When_CreatingRssFeed()
        {
            var controller = new RssController(context);

            var rssFeedResult = controller.GetRssFeedOfTranslations() as FileContentResult;
            var feed = GetFeed(rssFeedResult.FileContents);

            foreach (var item in feed.Items)
            {
                var currentItemsTitle = item.Title.Text;
                var currentItemsLink = item.Links.Single().Uri.OriginalString;
                var currentItemsCategory = item.Categories.Single().Name;

                var itemOnDatabase = context.Translations.Single(t => t.Title == currentItemsTitle);

                Assert.Equal(itemOnDatabase.Url, currentItemsLink);
                Assert.Equal(itemOnDatabase.Type.ToString(), currentItemsCategory);
            }
        }

        private SyndicationFeed GetFeed(byte[] xmlData)
        {
            using var stream = new MemoryStream(xmlData);
            using var streamReader = new StreamReader(stream);
            using var xmlReader = new XmlTextReader(streamReader);

            var feedFormatter = new Rss20FeedFormatter();
            feedFormatter.ReadFrom(xmlReader);
            return feedFormatter.Feed;
        }

        private bool IsRssFeed(byte[] xmlData)
        {
            using var stream = new MemoryStream(xmlData);
            using var streamReader = new StreamReader(stream);
            using var xmlReader = new XmlTextReader(streamReader);

            bool canBeReadAsAtom = new Atom10FeedFormatter().CanRead(xmlReader);
            bool canBeReadAsRss = new Rss20FeedFormatter().CanRead(xmlReader);

            return canBeReadAsRss && !canBeReadAsAtom;
        }
    }
}
