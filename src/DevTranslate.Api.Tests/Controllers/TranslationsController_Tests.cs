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
using DevTranslate.Api.DTO;

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

        [Fact]
        public void Should_ReturnOK_When_SearchingTranslations()
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(null);

            Assert.IsType<OkObjectResult>(searchResult);
            Assert.True((searchResult as OkObjectResult).StatusCode == (int)HttpStatusCode.OK);
        }

        [Fact]
        public void Should_ReturnEnumerableWithTenItems_When_SearchingTranslationsWithoutPaginationParameters()
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(null) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == 10);
        }

        [Fact]
        public void Should_ReturnPageTwo_When_SearchingPageTwo()
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(null, 2) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == 10);
            Assert.True(response.Translations.First().Id == 11);
            Assert.True(response.Pagination.Page == 2);
        }

        [Fact]
        public void Should_ReturnPageThree_When_SearchingPageThree()
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(null, 3) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == 5);
            Assert.True(response.Translations.First().Id == 21);
            Assert.True(response.Pagination.Page == 3);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Should_ReturnFirstPage_When_SearchingInvalidPage(int pageNumber)
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(null, pageNumber) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == 10);
            Assert.True(response.Translations.First().Id == 1);
            Assert.True(response.Pagination.Page == 1);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        [InlineData(11)]
        public void Should_ReturnDefaultNumberOfRecords_When_SearchingInvalidNumberOfRecords(int recordsPerPage)
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(null, pageSize: recordsPerPage) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == 10);
            Assert.True(response.Pagination.PageSize == 10);
        }

        [Theory]
        [InlineData("Title 2")]
        [InlineData("Title 17")]
        [InlineData("Title 23")]
        public void Should_FilterByTitle_When_UserSentAQuery(string query)
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(query: query) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.All(t => t.Title.Contains(query)));
            Assert.True(response.Translations.Any());
        }

        [Theory]
        [InlineData("Author 2")]
        [InlineData("Author 17")]
        [InlineData("Author 23")]
        public void Should_FilterByAuthor_When_UserSentAQuery(string query)
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(query: query) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.All(t => t.Author.Contains(query)));
            Assert.True(response.Translations.Any());
        }

        [Theory]
        [InlineData("Translator 2")]
        [InlineData("Translator 17")]
        [InlineData("Translator 23")]
        public void Should_FilterByTranslator_When_UserSentAQuery(string query)
        {
            var controller = new TranslationsController(context);

            var searchResult = controller.SearchTranslations(query: query) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.All(t => t.Translator.Contains(query)));
            Assert.True(response.Translations.Any());
        }
    }
}
