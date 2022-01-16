using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace DevTranslate.Api.Attributes
{
    public class OutputCacheAttribute : ActionFilterAttribute
    {
        private readonly string _cacheKey;

        private const string IsCachedResultItem = "IsCachedResult";

        public OutputCacheAttribute(string cacheKey)
        {
            _cacheKey = cacheKey;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {  
            var cache = context.HttpContext.RequestServices.GetService<IMemoryCache>();

            if (!cache.TryGetValue<IActionResult>(_cacheKey, out IActionResult cachedResult))
            {
                context.HttpContext.Items.Add(IsCachedResultItem, false);
                await next();
            }
            else
            {
                context.HttpContext.Items.Add(IsCachedResultItem, true);
                context.Result = cachedResult;
            }
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            bool isCachedResult = context.HttpContext.Items.ContainsKey(IsCachedResultItem)
                ? (bool)context.HttpContext.Items[IsCachedResultItem]
                : true;

            if (!isCachedResult)
            {
                var cache = context.HttpContext.RequestServices.GetService<IMemoryCache>();
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(2));

                cache.Set(_cacheKey, context.Result, cacheEntryOptions);
            }
        }
    }
}
