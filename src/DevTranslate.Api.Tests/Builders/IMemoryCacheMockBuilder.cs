using Microsoft.Extensions.Caching.Memory;
using Moq;
using System;

namespace DevTranslate.Api.Tests.Builders
{
    internal class IMemoryCacheMockBuilder
    {
        private string _cacheKey;
        private bool _result;

        public IMemoryCacheMockBuilder WithResultForCacheKey(string key, bool result)
        {
            _cacheKey = key;
            _result = result;

            return this;
        }

        public Mock<IMemoryCache> Build()
        {
            var memoryCacheMock = new Mock<IMemoryCache>();

            memoryCacheMock.Setup(m => m.CreateEntry(It.IsAny<object>())).Returns((string key) => new Mock<ICacheEntry>().Object);

            if (!String.IsNullOrWhiteSpace(_cacheKey))
                memoryCacheMock.Setup(m => m.TryGetValue(_cacheKey, out It.Ref<object>.IsAny)).Returns(_result);

            return memoryCacheMock;
        }
    }
}
