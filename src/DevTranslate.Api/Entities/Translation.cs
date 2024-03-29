﻿using DevTranslate.Api.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.Entities
{
    public class Translation
    {
        protected Translation()
        {
        }

        public Translation(string title, string author, string translator, Language language,
            string url, string imageUrl, TranslationStatus status, TranslationType type)
        {
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new RequiredPropertyNotProvidedException(nameof(title), "A title must be provided");
            }

            if (String.IsNullOrWhiteSpace(author))
            {
                throw new RequiredPropertyNotProvidedException(nameof(author), "An author must be provided");
            }

            if (String.IsNullOrWhiteSpace(translator))
            {
                throw new RequiredPropertyNotProvidedException(nameof(translator), "A translator must be provided");
            }

            if (String.IsNullOrWhiteSpace(url))
            {
                throw new RequiredPropertyNotProvidedException(nameof(url), "A url must be provided");
            }

            if (String.IsNullOrWhiteSpace(imageUrl))
            {
                throw new RequiredPropertyNotProvidedException(nameof(imageUrl), "An image url must be provided");
            }

            Title = title;
            Author = author;
            Translator = translator;
            Language = language;
            Url = url;
            ImageUrl = imageUrl;
            Status = status;
            Type = type;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Translator { get; private set; }
        public Language Language { get; private set; }
        public string Url { get; private set; }
        public string ImageUrl { get; private set; }
        public TranslationStatus Status { get; private set; }
        public TranslationType Type { get; private set; }
    }
}
