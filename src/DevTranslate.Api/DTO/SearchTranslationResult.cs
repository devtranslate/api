using DevTranslate.Api.Entities;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.DTO
{
    public class SearchTranslationResult
    {
        [SwaggerSchema(Nullable = false)]
        public int Id { get; set; }

        [SwaggerSchema(Nullable = false)]
        public string Title { get; set; }

        [SwaggerSchema(Nullable = false)]
        public string Author { get; set; }

        [SwaggerSchema(Nullable = false)]
        public string Translator { get; set; }

        [SwaggerSchema(Nullable = false)]
        public Language Language { get; set; }

        [SwaggerSchema(Nullable = false)]
        public string Url { get; set; }

        [SwaggerSchema(Nullable = false)]
        public string ImageUrl { get; set; }

        [SwaggerSchema(Nullable = false)]
        public TranslationStatus Status { get; set; }

        [SwaggerSchema(Nullable = false)]
        public TranslationType Type { get; set; }
    }
}
