using DevTranslate.Api.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevTranslate.Api.Tests.Builders
{
    public class TranslationBuilder
    {
        private string title;
        private string author;
        private string translator;
        private Language language;
        private string url;
        private string imageUrl;
        private Status status;
        private TranslationType translationType;

        public TranslationBuilder()
        {
            title = "Pare de usar CSS no JavaScript para desenvolvimento web";
            author = "Gajus Kuizinas";
            translator = "Carlos Eduardo Olivieri";
            language = Language.English;
            url = "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e";
            imageUrl = "https://image.ibb.co/b9GdKb/1.png";
            status = Status.Completed;
            translationType = TranslationType.Articles;
        }

        public Translation Build()
        {
            return new Translation(title, author, translator, language, url, imageUrl, status, translationType);
        }

        public TranslationBuilder WithTitle(string title)
        {
            this.title = title;
            return this;
        }

        public TranslationBuilder WithAuthor(string author)
        {
            this.author = author;
            return this;
        }

        public TranslationBuilder WithTranslator(string translator)
        {
            this.translator = translator;
            return this;
        }

        public TranslationBuilder WithUrl(string url)
        {
            this.url = url;
            return this;
        }

        public TranslationBuilder WithImageUrl(string imageUrl)
        {
            this.imageUrl = imageUrl;
            return this;
        }
    }
}
