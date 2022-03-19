using DevTranslate.Api.Context;
using DevTranslate.Api.Controllers;
using DevTranslate.Api.DTO;
using DevTranslate.Api.Entities;
using DevTranslate.Api.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xunit;

namespace DevTranslate.Api.Tests.Controllers
{
    public class TranslationsController_Tests
    {
        private readonly DevTranslateContext context;

        public TranslationsController_Tests()
        {
            DbContextOptions<DevTranslateContext> options = new DbContextOptionsBuilder<DevTranslateContext>()
                .UseInMemoryDatabase(databaseName: "DevTranslateInMemoryDbForTranslations")
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
        public void Should_ReturnHttpOk_When_SearchReturnsResults()
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
            };

            var searchResult = controller.SearchTranslations(request) ;

            Assert.IsType<OkObjectResult>(searchResult);
            Assert.True((searchResult as OkObjectResult).StatusCode == (int)HttpStatusCode.OK);
        }

        [Fact]
        public void Should_ReturnHttpOk_When_SearchResultIsEmpty()
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
            };

            var searchResult = controller.SearchTranslations(request) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsType<OkObjectResult>(searchResult);
            Assert.True(searchResult.StatusCode == (int)HttpStatusCode.OK);
            Assert.NotEmpty(response.Translations);
        }

        [Fact]
        public void Should_FallbackToTenItems_When_YouDontSpecifyPageSize()
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
            };

            var searchResult = controller.SearchTranslations(request) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == 10);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void Should_ReturnTheSpecifiedNumberOfItems_When_YouSpecifyThePageSizeUpToTheMaximum(int pageSize)
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
                PageSize = pageSize,
            };

            var searchResult = controller.SearchTranslations(request) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == pageSize);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Should_ReturnBadRequest_When_TheSpecifiedPageSizeIsInvalid(int recordsPerPage)
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
                PageSize = recordsPerPage
            };

            var searchResult = controller.SearchTranslations(request) as BadRequestObjectResult;
            var searchResultValue = searchResult.Value as string;

            Assert.NotNull(searchResult);
            Assert.NotNull(searchResultValue);
            Assert.True(searchResultValue.Contains("page size", StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData(11)]
        [InlineData(45)]
        public void Should_FallbackToTenRecords_When_TheSpecifiedPageSizeIsHigherThanTen(int recordsPerPage)
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
                PageSize = recordsPerPage
            };

            var searchResult = controller.SearchTranslations(request) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == Pagination.MaxPageSize);
            Assert.True(response.Pagination.PageSize == Pagination.MaxPageSize);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void Should_ReturnTheSpecifiedPageOfResults_When_Searching(int pageNumber)
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
                Page = pageNumber
            };

            var searchResult = controller.SearchTranslations(request) as OkObjectResult;
            var response = searchResult.Value as SearchTranslationResponse;
            var page = GetPageForRequest(pageNumber);

            Assert.IsAssignableFrom<SearchTranslationResponse>(searchResult.Value);
            Assert.True(response.Translations.Count() == page.Count);
            Assert.True(response.Translations.All(t => page.Any(fp => fp.Title == t.Title)));
            Assert.True(response.Pagination.Page == pageNumber);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-5)]
        public void Should_ReturnBadRequest_When_SpecifiedPageIsInvalid(int pageNumber)
        {
            var controller = new TranslationsController(context);
            var request = new SearchTranslationRequest()
            {
                Query = null,
                Page = pageNumber
            };

            var searchResult = controller.SearchTranslations(request) as BadRequestObjectResult;
            var searchResultValue = searchResult.Value as string;

            Assert.NotNull(searchResult);
            Assert.NotNull(searchResultValue);
            Assert.True(searchResultValue.Contains("page number", StringComparison.CurrentCultureIgnoreCase));
        }

        [Theory]
        [InlineData("Voluptas")]
        [InlineData("Ex Consectetur Voluptatem Quod Quia")]
        [InlineData("Laborum")]
        [InlineData("LABORUM")]
        [InlineData("voluPTAS")]
        public void Should_FilterByTitle_When_Searching(string query)
        {
            var request = new SearchTranslationRequest()
            {
                Query = query,
            };

            var translations = GetAllPagesForRequest(request);

            Assert.True(translations.All(t => t.Title.Contains(query, System.StringComparison.CurrentCultureIgnoreCase)));
            Assert.True(translations.Any());
        }

        [Theory]
        [InlineData("Lucas Pollich")]
        [InlineData("Terence")]
        [InlineData("Terence Wolff")]
        [InlineData("TERENCE")]
        [InlineData("tEREnCE")]
        public void Should_FilterByAuthor_When_Searching(string query)
        {
            var request = new SearchTranslationRequest()
            {
                Query = query,
            };

            var translations = GetAllPagesForRequest(request);

            Assert.True(translations.All(t => t.Author.Contains(query, System.StringComparison.CurrentCultureIgnoreCase)));
            Assert.True(translations.Any());
        }

        [Theory]
        [InlineData("Jamaal")]
        [InlineData("Jamaal Boehm")]
        [InlineData("Jamaal Morar")]
        [InlineData("Buddy")]
        [InlineData("BUDDY")]
        [InlineData("buDDy")]
        public void Should_FilterByTranslator_When_Searching(string query)
        {
            var request = new SearchTranslationRequest()
            {
                Query = query,
            };

            var translations = GetAllPagesForRequest(request);

            Assert.True(translations.All(t => t.Translator.Contains(query, System.StringComparison.CurrentCultureIgnoreCase)));
            Assert.True(translations.Any());
        }

        [Theory]
        [InlineData(Language.Portuguese)]
        [InlineData(Language.English)]
        public void Should_FilterByLanguage_When_Searching(Language language)
        {
            var request = new SearchTranslationRequest()
            {
                Query = null,
                Language = language
            };

            var translations = GetAllPagesForRequest(request);

            Assert.True(translations.All(t => t.Language == language));
            Assert.True(translations.Any());
        }

        [Theory]
        [InlineData(TranslationStatus.Completed)]
        [InlineData(TranslationStatus.InProgress)]
        public void Should_FilterByStatus_When_Searching(TranslationStatus status)
        {
            var request = new SearchTranslationRequest()
            {
                Query = null,
                Status = status
            };

            var translations = GetAllPagesForRequest(request);

            Assert.True(translations.All(t => t.Status == status));
            Assert.True(translations.Any());
        }

        [Theory]
        [InlineData(TranslationType.Articles)]
        [InlineData(TranslationType.Books)]
        [InlineData(TranslationType.Documentation)]
        public void Should_FilterByType_When_Searching(TranslationType type)
        {
            var request = new SearchTranslationRequest()
            {
                Query = null,
                Type = type
            };

            var translations = GetAllPagesForRequest(request);

            Assert.True(translations.All(t => t.Type == type));
            Assert.True(translations.Any());
        }

        [Fact]
        public void Should_OrderTranslationsById_When_Searching()
        {
            var translationsFromDb = context.Translations.ToList();
            var translationsFromController = GetAllPagesForRequest(new SearchTranslationRequest());

            var idsFromDb = translationsFromDb.Select(t => t.Id).ToList();
            var idsFromController = translationsFromController.Select(t => t.Id).ToList();

            Assert.True(idsFromDb.SequenceEqual(idsFromController));
        }

        private List<SearchTranslationResult> GetAllPagesForRequest(SearchTranslationRequest request)
        {
            var result = new List<SearchTranslationResult>();
            var controller = new TranslationsController(context);
            int currentPageNumber = 0;

            SearchTranslationResponse response = null;

            do
            {
                request.Page = ++currentPageNumber;

                var searchResult = controller.SearchTranslations(request) as OkObjectResult;
                response = searchResult.Value as SearchTranslationResponse;

                result.AddRange(response.Translations);

            } while (response.Translations.Any());

            return result;
        }

        private List<Translation> GetPageForRequest(int pageNumber, int pageSize = 10)
        {
            return context.Translations
                .Skip((pageNumber-1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
