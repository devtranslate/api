using DevTranslate.Api.Entities;
using DevTranslate.Api.Tests.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace DevTranslate.Api.Tests.Entities
{
    public class Translation_Tests
    {
        [Fact]
        public void Should_CreateInstance_When_Instantiating()
        {
            var translation = new TranslationBuilder().Build();

            Assert.NotNull(translation);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_TitleIsNullOrEmpty(string titulo)
        {
            Assert.Throws<ArgumentNullException>("title", () =>
            {
                var translation = new TranslationBuilder()
                    .WithTitle(titulo)
                    .Build();
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_AuthorIsNullOrEmpty(string author)
        {
            Assert.Throws<ArgumentNullException>("author", () =>
            {
                var translation = new TranslationBuilder()
                    .WithAuthor(author)
                    .Build();
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_TranslatorIsNullOrEmpty(string translator)
        {
            Assert.Throws<ArgumentNullException>("translator", () =>
            {
                var translation = new TranslationBuilder()
                    .WithTranslator(translator)
                    .Build();
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_UrlIsNullOrEmpty(string url)
        {
            Assert.Throws<ArgumentNullException>("url", () =>
            {
                var translation = new TranslationBuilder()
                    .WithUrl(url)
                    .Build();
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_ImageUrlIsNullOrEmpty(string imageUrl)
        {
            Assert.Throws<ArgumentNullException>("imageUrl", () =>
            {
                var translation = new TranslationBuilder()
                    .WithImageUrl(imageUrl)
                    .Build();
            });
        }
    }
}
