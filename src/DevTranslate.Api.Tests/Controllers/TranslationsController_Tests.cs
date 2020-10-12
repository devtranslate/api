using DevTranslate.Api.Context;
using DevTranslate.Api.Controllers;
using DevTranslate.Api.Entities;
using DevTranslate.Api.Tests.Builders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace DevTranslate.Api.Tests.Controllers
{
    public class TranslationsController_Tests
    {
        private readonly DbContextOptions<DevTranslateContext> options;
        private readonly DevTranslateContext context;

        public TranslationsController_Tests()
        {
            options = new DbContextOptionsBuilder<DevTranslateContext>()
                .UseInMemoryDatabase(databaseName: "DevTranslateDb")
                .Options;

            context = new DevTranslateContext(options);

            for (int i=1; i <= 25; i++)
            {
                context.Translations.Add(new Translation(
                    title: $"Title {i}",
                    author: $"Author {i}",
                    translator: $"Translator {i}",
                    language: Language.Portuguese,
                    url: $"https://link.devtranslate.io/{i}",
                    imageUrl: $"https://cdn.devtranslate.io/images/{i}.png",
                    status: TranslationStatus.Completed,
                    type: TranslationType.Articles
                ));
            }

            context.SaveChanges();
        }

        //  Red, Green, Refactor
        [Fact]
        public void Should_ReturnOK_When_SearchingTranslations()
        {
            // A - Arrange
            var controller = new TranslationsController(context);

            // A - Act
            var searchResult = controller.SearchTranslations();

            // A - Assert
            Assert.IsType<OkObjectResult>(searchResult);
            Assert.True((searchResult as OkObjectResult).StatusCode == (int)HttpStatusCode.OK);
        }

        [Fact]
        public void Should_ReturnEnumerableWithTenItems_When_SearchingTranslationsWithoutPaginationParameters()
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations() as OkObjectResult;

            Assert.IsAssignableFrom<ICollection>(searchResult.Value);
            Assert.True((searchResult.Value as ICollection).Count == 10);
        }
    }
}
