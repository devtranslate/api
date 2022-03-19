using DevTranslate.Api.Exceptions;
using DevTranslate.Api.Tests.Builders;
using System;
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
        public void Should_ThrowException_When_TitleIsNullOrEmpty(string title)
        {
            var exception = Assert.Throws<RequiredPropertyNotProvidedException>(() =>
            {
                var translation = new TranslationBuilder()
                    .WithTitle(title)
                    .Build();
            });

            Assert.True(exception.ParamName == "title");
            Assert.True(exception.Message.Contains("title", StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_AuthorIsNullOrEmpty(string author)
        {
            var exception = Assert.Throws<RequiredPropertyNotProvidedException>(() =>
            {
                var translation = new TranslationBuilder()
                    .WithAuthor(author)
                    .Build();
            });

            Assert.True(exception.ParamName == "author");
            Assert.True(exception.Message.Contains("author", StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_TranslatorIsNullOrEmpty(string translator)
        {
            var exception = Assert.Throws<RequiredPropertyNotProvidedException>(() =>
            {
                var translation = new TranslationBuilder()
                    .WithTranslator(translator)
                    .Build();
            });

            Assert.True(exception.ParamName == "translator");
            Assert.True(exception.Message.Contains("translator", StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_UrlIsNullOrEmpty(string url)
        {
            var exception = Assert.Throws<RequiredPropertyNotProvidedException>(() =>
            {
                var translation = new TranslationBuilder()
                    .WithUrl(url)
                    .Build();
            });

            Assert.True(exception.ParamName == "url");
            Assert.True(exception.Message.Contains("url", StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_ImageUrlIsNullOrEmpty(string imageUrl)
        {
            var exception = Assert.Throws<RequiredPropertyNotProvidedException>(() =>
            {
                var translation = new TranslationBuilder()
                    .WithImageUrl(imageUrl)
                    .Build();
            });

            Assert.True(exception.ParamName == "imageUrl");
            Assert.True(exception.Message.Contains("image url", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
