using DevTranslate.Api.Attributes;
using DevTranslate.Api.Tests.Builders;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace DevTranslate.Api.Tests.Attributes
{
    public class OutputCache_Tests
    {
        private const string CacheKey = "RssFeedResult";

        [Fact]
        public void Should_SetInMemoryCache_When_HttpContextIndicatesTheRequestDidntComeFromCache()
        {
            var memoryCacheMock = new IMemoryCacheMockBuilder().Build();
            var httpContextMock = GetTestHttpContext(GetNonCachedResultHttpItems(), memoryCacheMock.Object);
            var outputCacheAttribute = new OutputCacheAttribute(CacheKey);
            var resultExecutedContext = new ResultExecutedContext(new ActionContext(httpContextMock, new RouteData(), new ActionDescriptor()), new List<IFilterMetadata>(), new OkResult(), null);

            outputCacheAttribute.OnResultExecuted(resultExecutedContext);

            memoryCacheMock.Verify(m => m.CreateEntry(CacheKey), Times.Once);
        }

        [Fact]
        public async Task Should_ExecuteControllerAction_When_ResultIsNotCached()
        {
            var memoryCacheMock = new IMemoryCacheMockBuilder().WithResultForCacheKey(CacheKey, false).Build();
            var outputCacheAttribute = new OutputCacheAttribute(CacheKey);
            var delegateMock = new Mock<ActionExecutionDelegate>();
            var httpContextMock = GetTestHttpContext(GetEmptyHttpItems(), memoryCacheMock.Object);
            var actionExecutingContext = new ActionExecutingContext(new ActionContext(httpContextMock, new RouteData(), new ActionDescriptor()), new List<IFilterMetadata>(), new Dictionary<string, object>(), null);

            await outputCacheAttribute.OnActionExecutionAsync(actionExecutingContext, delegateMock.Object);

            delegateMock.Verify(x => x.Invoke(), Times.Once());
            Assert.False(Convert.ToBoolean(httpContextMock.Items["IsCachedResult"]));
        }

        [Fact]
        public async Task Should_NotExecuteControllerAction_When_ResultIsCached()
        {
            var memoryCacheMock = new IMemoryCacheMockBuilder().WithResultForCacheKey(CacheKey, true).Build();
            var outputCacheAttribute = new OutputCacheAttribute(CacheKey);
            var delegateMock = new Mock<ActionExecutionDelegate>();
            var httpContextMock = GetTestHttpContext(GetEmptyHttpItems(), memoryCacheMock.Object);
            var actionExecutingContext = new ActionExecutingContext(new ActionContext(httpContextMock, new RouteData(), new ActionDescriptor()), new List<IFilterMetadata>(), new Dictionary<string, object>(), null);

            await outputCacheAttribute.OnActionExecutionAsync(actionExecutingContext, delegateMock.Object);

            delegateMock.Verify(x => x.Invoke(), Times.Never);
            Assert.True(Convert.ToBoolean(httpContextMock.Items["IsCachedResult"]));
        }

        [Fact]
        public void Should_NotSetInMemoryCache_When_HttpContextIndicatesTheRequestComeFromCache()
        {
            var memoryCacheMock = new IMemoryCacheMockBuilder().Build();
            var httpContextMock = GetTestHttpContext(GetCachedResultHttpItems(), memoryCacheMock.Object);
            var outputCacheAttribute = new OutputCacheAttribute(CacheKey);
            var resultExecutedContext = new ResultExecutedContext(new ActionContext(httpContextMock, new RouteData(), new ActionDescriptor()), new List<IFilterMetadata>(), new OkResult(), null);

            outputCacheAttribute.OnResultExecuted(resultExecutedContext);

            memoryCacheMock.Verify(m => m.CreateEntry(It.IsAny<object>()), Times.Never);
        }

        [Fact]
        public void Should_NotSetInMemoryCache_When_HttpContextHasNoItems()
        {
            var memoryCacheMock = new IMemoryCacheMockBuilder().Build();
            var httpContextMock = GetTestHttpContext(GetEmptyHttpItems(), memoryCacheMock.Object);
            var outputCacheAttribute = new OutputCacheAttribute(CacheKey);
            var resultExecutedContext = new ResultExecutedContext(new ActionContext(httpContextMock, new RouteData(), new ActionDescriptor()), new List<IFilterMetadata>(), new OkResult(), null);

            outputCacheAttribute.OnResultExecuted(resultExecutedContext);

            memoryCacheMock.Verify(m => m.CreateEntry(It.IsAny<object>()), Times.Never);
        }

        private HttpContext GetTestHttpContext(Dictionary<object, object> items, IMemoryCache memoryCache)
        {
            var services = new ServiceCollection();

            services.AddScoped<IMemoryCache>(p => memoryCache);

            return new DefaultHttpContext()
            {
                Items = items,
                RequestServices = services.BuildServiceProvider()
            };
        }

        private Dictionary<object, object> GetEmptyHttpItems()
        {
            return new Dictionary<object, object>();
        }

        private Dictionary<object, object> GetCachedResultHttpItems()
        {
            var result = new Dictionary<object, object>();

            result.Add("IsCachedResult", true);

            return result;
        }

        private Dictionary<object, object> GetNonCachedResultHttpItems()
        {
            var result = new Dictionary<object, object>();

            result.Add("IsCachedResult", false);

            return result;
        }
    }
}
