using DevTranslate.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.DTO
{
    public class SearchTranslationResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Translator { get; set; }
        public Language Language { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public TranslationStatus Status { get; set; }
        public TranslationType Type { get; set; }
    }
}
