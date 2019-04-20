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
                author: null,
                translator: null,
                language: Language.English,
                url: null,
                imageUrl: null,
                status: Status.Completed,
                type: TranslationType.Articles
            );

            Assert.NotNull(translation);
        }

        [Fact]
        public void Should_ThrowException_When_TitleIsNullOrEmpty()
        {
            Assert.Throws<ArgumentNullException>("title", () =>
            {
                var translation = new Translation(null, null, null, Language.English, null, null, Status.Completed, Api.Entities.TranslationType.Articles);
            });
        }
    }
}
