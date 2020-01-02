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
            string url, string imageUrl, Status status, TranslationType type)
        {
            if (String.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("title", "A title must be provided");
            }

            if (String.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentNullException("author", "An author must be provided");
            }

            if (String.IsNullOrWhiteSpace(translator))
            {
                throw new ArgumentNullException("translator", "A translator must be provided");
            }

            if (String.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url", "A url must be provided");
            }

            if (String.IsNullOrWhiteSpace(imageUrl))
            {
                throw new ArgumentNullException("imageUrl", "An image url must be provided");
            }
        }
    }
}
