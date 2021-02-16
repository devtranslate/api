using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.DTO
{
    public class SearchTranslationResponse : ApiPaginatedResponse
    {
        public SearchTranslationResponse(IQueryable<SearchTranslationResult> translations, PaginationResponse pagination)
        {
            Translations = translations.ToList();
            Pagination = pagination;
        }

        [SwaggerSchema(Nullable = false)]
        public List<SearchTranslationResult> Translations { get; set; }
    }
}
