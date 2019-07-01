using DevTranslate.Api.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DevTranslate.Api.Tests.Entities
{
    public class Translation_Tests
    {
        [Fact]
        public void Should_CreateInstance_When_Instantiating()
        {
            var translation = new Translation(
                title: "Pare de usar CSS no JavaScript para desenvolvimento web",
                author: "Gajus Kuizinas",
                translator: "Carlos Eduardo Olivieri",
                language: Language.English,
                url: "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                imageUrl: "https://image.ibb.co/b9GdKb/1.png",
                status: Status.Completed,
                type: TranslationType.Articles
            );

            Assert.NotNull(translation);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_TitleIsNullOrEmpty(string titulo)
        {
            Assert.Throws<ArgumentNullException>("title", () =>
            {
                var translation = new Translation(
                    title: titulo,
                    author: "Gajus Kuizinas",
                    translator: "Carlos Eduardo Olivieri",
                    language: Language.English,
                    url: "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                    imageUrl: "https://image.ibb.co/b9GdKb/1.png",
                    status: Status.Completed,
                    type: TranslationType.Articles
                );
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_AuthorIsNullOrEmpty(string author)
        {
            Assert.Throws<ArgumentNullException>("author", () =>
            {
                var translation = new Translation(
                    title: "Pare de usar CSS no JavaScript para desenvolvimento web",
                    author: author,
                    translator: "Carlos Eduardo Olivieri",
                    language: Language.English,
                    url: "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                    imageUrl: "https://image.ibb.co/b9GdKb/1.png",
                    status: Status.Completed,
                    type: TranslationType.Articles
                );
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_TranslatorIsNullOrEmpty(string translator)
        {
            Assert.Throws<ArgumentNullException>("translator", () =>
            {
                var translation = new Translation(
                    title: "Pare de usar CSS no JavaScript para desenvolvimento web",
                    author: "Gajus Kuizinas",
                    translator: translator,
                    language: Language.English,
                    url: "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                    imageUrl: "https://image.ibb.co/b9GdKb/1.png",
                    status: Status.Completed,
                    type: TranslationType.Articles
                );
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_UrlIsNullOrEmpty(string url)
        {
            Assert.Throws<ArgumentNullException>("url", () =>
            {
                var translation = new Translation(
                    title: "Pare de usar CSS no JavaScript para desenvolvimento web",
                    author: "Gajus Kuizinas",
                    translator: "Carlos Eduardo Olivieri",
                    language: Language.English,
                    url: url,
                    imageUrl: "https://image.ibb.co/b9GdKb/1.png",
                    status: Status.Completed,
                    type: TranslationType.Articles
                );
            });
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_ThrowException_When_ImageUrlIsNullOrEmpty(string imageUrl)
        {
            Assert.Throws<ArgumentNullException>("imageUrl", () =>
            {
                var translation = new Translation(
                    title: "Pare de usar CSS no JavaScript para desenvolvimento web",
                    author: "Gajus Kuizinas",
                    translator: "Carlos Eduardo Olivieri",
                    language: Language.English,
                    url: "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                    imageUrl: imageUrl,
                    status: Status.Completed,
                    type: TranslationType.Articles
                );
            });
        }
    }
}
