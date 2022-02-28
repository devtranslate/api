using DevTranslate.Api.Context;
using DevTranslate.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace DevTranslate.Api.Tests.Controllers
{
    public class RssController_Tests
    {
        private readonly DbContextOptions<DevTranslateContext> options;
        private readonly DevTranslateContext context;

        public RssController_Tests()
        {
            options = new DbContextOptionsBuilder<DevTranslateContext>()
                .UseInMemoryDatabase(databaseName: "DevTranslateDb")
                .Options;

            context = new DevTranslateContext(options);

            foreach (var translation in MockedData.All)
            {
                context.Translations.Add(translation);
            }

            context.SaveChanges();
        }

        [Fact]
        public void Should_ReturnHttpOk_When_RequestsRssFeed()
        {
            var controller = new RssController(context);

            var rssFeedResult = controller.Index() as FileContentResult;

            Assert.NotNull(rssFeedResult);
            Assert.True(rssFeedResult.FileContents.Length > 0);
            Assert.True(rssFeedResult.ContentType == "application/rss+xml; charset=utf-8");
        }
    }
}
