using DevTranslate.Api.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.DTO
{
    public class SearchTranslationRequest
    {
        [SwaggerParameter("Query text for searching translations by title, author or translator. Any translation with that contains the text in any of these fields will be returned.")]
        public string Query { get; set; }

        [SwaggerParameter("The number of the page of records to be returned. Defaults to 1.")]
        public int? Page { get; set; }

        [SwaggerParameter("Number of items per page. Can not be higher than 10 which is also its default value.")]
        public int? PageSize { get; set; }

        [SwaggerParameter("Status of the translations to be returned.")]
        public TranslationStatus? Status { get; set; }

        [SwaggerParameter("Language of the translations to be returned.")]
        public Language? Language { get; set; }

        [SwaggerParameter("Type of the translations to be returned.")]
        public TranslationType? Type { get; set; }
    }
}
