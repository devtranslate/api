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
        }
    }
}
