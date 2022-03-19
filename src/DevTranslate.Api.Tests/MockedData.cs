using DevTranslate.Api.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DevTranslate.Api.Tests
{
    internal static class MockedData
    {
        public static IReadOnlyList<Translation> All => all.AsReadOnly();

        public static IReadOnlyList<Translation> ByAuthor(string author)
            => all.Where(x => x.Author == author).ToList().AsReadOnly();

        public static IReadOnlyList<Translation> ByTranslator(string translator)
            => all.Where(x => x.Translator == translator).ToList().AsReadOnly();

        public static IReadOnlyList<Translation> ByStatus(TranslationStatus status)
            => all.Where(x => x.Status == status).ToList().AsReadOnly();

        public static IReadOnlyList<Translation> ByLanguage(Language language)
            => all.Where(x => x.Language == language).ToList().AsReadOnly();

        public static IReadOnlyList<Translation> ByType(TranslationType type)
            => all.Where(x => x.Type == type).ToList().AsReadOnly();

        private static List<Translation> all => new List<Translation>()
        {
            new Translation(
                title: "Atque Nesciunt Ad Molestiae Doloribus Eum",
                author: "Mateo Bauch",
                translator: "Jamaal Morar",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/1",
                imageUrl: "https://cdn.devtranslate.io/images/1.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Dicta Voluptas Nobis Ipsam",
                author: "Lucas Pollich",
                translator: "Buddy Glover",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/2",
                imageUrl: "https://cdn.devtranslate.io/images/2.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Ipsa Molestias Temporibus Expedita Ullam Non Consequatur",
                author: "Terence Wolff",
                translator: "Laney Crist",
                language: Language.English,
                url: "https://link.devtranslate.io/3",
                imageUrl: "https://cdn.devtranslate.io/images/3.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Soluta Cumque Aliquid Saepe Alias Consectetur Qui",
                author: "Terence Wolff",
                translator: "Danial Boehm",
                language: Language.English,
                url: "https://link.devtranslate.io/4",
                imageUrl: "https://cdn.devtranslate.io/images/4.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Maxime Eos Qui Aspernatur",
                author: "Terence Bauch",
                translator: "Buddy Glover",
                language: Language.English,
                url: "https://link.devtranslate.io/5",
                imageUrl: "https://cdn.devtranslate.io/images/5.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Maiores Voluptas Expedita Autem Rerum",
                author: "Terence Wolff",
                translator: "Jamaal Morar",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/6",
                imageUrl: "https://cdn.devtranslate.io/images/6.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Et Laborum Molestias Est Voluptatum Non Quo",
                author: "Mateo Bauch",
                translator: "Ethel Haag",
                language: Language.English,
                url: "https://link.devtranslate.io/7",
                imageUrl: "https://cdn.devtranslate.io/images/7.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Veritatis Qui Et Consequuntur Nam",
                author: "Lucas Pollich",
                translator: "Jamaal Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/8",
                imageUrl: "https://cdn.devtranslate.io/images/8.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Est Eos A Amet",
                author: "Alphonso Wisoky",
                translator: "Jamaal Morar",
                language: Language.English,
                url: "https://link.devtranslate.io/9",
                imageUrl: "https://cdn.devtranslate.io/images/9.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Iste Saepe Alias Non Quia Deleniti",
                author: "Alphonso Wisoky",
                translator: "Ethel Haag",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/10",
                imageUrl: "https://cdn.devtranslate.io/images/10.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Ut Consequuntur Consectetur Labore Ipsam Nisi Earum",
                author: "Alphonso Wisoky",
                translator: "Jamaal Morar",
                language: Language.English,
                url: "https://link.devtranslate.io/11",
                imageUrl: "https://cdn.devtranslate.io/images/11.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Officiis Voluptatum Consequatur Est Vel Mollitia Quo",
                author: "Alphonso Wisoky",
                translator: "Jamaal Morar",
                language: Language.English,
                url: "https://link.devtranslate.io/12",
                imageUrl: "https://cdn.devtranslate.io/images/12.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Eveniet Voluptatem Quis Fugiat Dolores",
                author: "Lucas Pollich",
                translator: "Ethel Haag",
                language: Language.English,
                url: "https://link.devtranslate.io/13",
                imageUrl: "https://cdn.devtranslate.io/images/13.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Aut Sit Autem Tempore Quod Aut Et",
                author: "Terence Wolff",
                translator: "Wilfrid Aufderhar",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/14",
                imageUrl: "https://cdn.devtranslate.io/images/14.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Nulla Minus Tenetur Quo",
                author: "Lucas Pollich",
                translator: "Danial Boehm",
                language: Language.English,
                url: "https://link.devtranslate.io/15",
                imageUrl: "https://cdn.devtranslate.io/images/15.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Aperiam Quia Voluptates Id Aperiam Nihil Fugit",
                author: "Lucas Pollich",
                translator: "Wilfrid Aufderhar",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/16",
                imageUrl: "https://cdn.devtranslate.io/images/16.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Eius Aspernatur Harum Adipisci",
                author: "Lucas Pollich",
                translator: "Jamaal Morar",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/17",
                imageUrl: "https://cdn.devtranslate.io/images/17.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Minima Sunt Et Qui",
                author: "Mateo Bauch",
                translator: "Danial Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/18",
                imageUrl: "https://cdn.devtranslate.io/images/18.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Eaque Praesentium Eligendi Est Iure Iusto Quia",
                author: "Newton Crist",
                translator: "Laney Crist",
                language: Language.English,
                url: "https://link.devtranslate.io/19",
                imageUrl: "https://cdn.devtranslate.io/images/19.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Ea Facere Repellat Omnis",
                author: "Terence Wolff",
                translator: "Jamaal Morar",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/20",
                imageUrl: "https://cdn.devtranslate.io/images/20.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Nostrum Omnis Sit Enim Dolorem Magni",
                author: "Hardy Stark",
                translator: "Buddy Glover",
                language: Language.English,
                url: "https://link.devtranslate.io/21",
                imageUrl: "https://cdn.devtranslate.io/images/21.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Illum Voluptas Eos Dolorum Itaque Cumque",
                author: "Mateo Bauch",
                translator: "Danial Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/22",
                imageUrl: "https://cdn.devtranslate.io/images/22.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Qui Laborum Repellat Officiis Assumenda",
                author: "Hardy Stark",
                translator: "Buddy Glover",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/23",
                imageUrl: "https://cdn.devtranslate.io/images/23.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Ex Consectetur Voluptatem Quod Quia",
                author: "Alphonso Wisoky",
                translator: "Buddy Glover",
                language: Language.English,
                url: "https://link.devtranslate.io/24",
                imageUrl: "https://cdn.devtranslate.io/images/24.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Doloribus Expedita Veniam Ratione Animi Atque",
                author: "Terence Wolff",
                translator: "Buddy Glover",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/25",
                imageUrl: "https://cdn.devtranslate.io/images/25.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Dolorem Quibusdam Rem Consequatur Et Est Ea",
                author: "Newton Crist",
                translator: "Buddy Glover",
                language: Language.English,
                url: "https://link.devtranslate.io/26",
                imageUrl: "https://cdn.devtranslate.io/images/26.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Est Et Pariatur Quibusdam Modi",
                author: "Alphonso Wisoky",
                translator: "Buddy Glover",
                language: Language.English,
                url: "https://link.devtranslate.io/27",
                imageUrl: "https://cdn.devtranslate.io/images/27.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Hic Magnam Et Iusto Commodi Ipsum",
                author: "Mateo Bauch",
                translator: "Jamaal Morar",
                language: Language.English,
                url: "https://link.devtranslate.io/28",
                imageUrl: "https://cdn.devtranslate.io/images/28.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Labore Enim Ab Doloribus Laboriosam",
                author: "Hardy Stark",
                translator: "Danial Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/29",
                imageUrl: "https://cdn.devtranslate.io/images/29.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Doloremque Hic Ratione Et Laborum Ut Mollitia",
                author: "Hardy Stark",
                translator: "Wilfrid Aufderhar",
                language: Language.English,
                url: "https://link.devtranslate.io/30",
                imageUrl: "https://cdn.devtranslate.io/images/30.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Temporibus Repellat Laboriosam Enim Recusandae",
                author: "Lucas Pollich",
                translator: "Danial Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/31",
                imageUrl: "https://cdn.devtranslate.io/images/31.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Perspiciatis Facilis Sunt Fugiat Molestiae Et",
                author: "Mateo Bauch",
                translator: "Laney Crist",
                language: Language.English,
                url: "https://link.devtranslate.io/32",
                imageUrl: "https://cdn.devtranslate.io/images/32.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Dolores Quod Et Voluptatem Itaque Quaerat Repudiandae",
                author: "Alphonso Wisoky",
                translator: "Danial Boehm",
                language: Language.English,
                url: "https://link.devtranslate.io/33",
                imageUrl: "https://cdn.devtranslate.io/images/33.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Books
            ),
            new Translation(
                title: "Magni Nisi Nesciunt Rerum Est",
                author: "Mateo Bauch",
                translator: "Ethel Haag",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/34",
                imageUrl: "https://cdn.devtranslate.io/images/34.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Est Distinctio Et Reiciendis Aut Dolores Necessitatibus",
                author: "Terence Wolff",
                translator: "Ethel Haag",
                language: Language.English,
                url: "https://link.devtranslate.io/35",
                imageUrl: "https://cdn.devtranslate.io/images/35.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Qui Modi Sit Cum Voluptas",
                author: "Mateo Bauch",
                translator: "Ethel Haag",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/36",
                imageUrl: "https://cdn.devtranslate.io/images/36.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Quia Mollitia Est Expedita",
                author: "Hardy Stark",
                translator: "Danial Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/37",
                imageUrl: "https://cdn.devtranslate.io/images/37.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Voluptatem Quia A Ipsam Excepturi",
                author: "Newton Crist",
                translator: "Danial Boehm",
                language: Language.English,
                url: "https://link.devtranslate.io/38",
                imageUrl: "https://cdn.devtranslate.io/images/38.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Voluptatibus Quibusdam Dicta Ut",
                author: "Terence Wolff",
                translator: "Buddy Glover",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/39",
                imageUrl: "https://cdn.devtranslate.io/images/39.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Doloremque Porro Laudantium Mollitia Pariatur Iste Corporis",
                author: "Mateo Bauch",
                translator: "Danial Boehm",
                language: Language.English,
                url: "https://link.devtranslate.io/40",
                imageUrl: "https://cdn.devtranslate.io/images/40.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Others
            ),
            new Translation(
                title: "Dolor Corrupti Porro Nihil Ut Et",
                author: "Terence Wolff",
                translator: "Danial Boehm",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/41",
                imageUrl: "https://cdn.devtranslate.io/images/41.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Quos Magni Blanditiis Inventore Voluptatem",
                author: "Lucas Pollich",
                translator: "Danial Boehm",
                language: Language.English,
                url: "https://link.devtranslate.io/42",
                imageUrl: "https://cdn.devtranslate.io/images/42.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Debitis Reiciendis Labore Odit",
                author: "Mateo Bauch",
                translator: "Buddy Glover",
                language: Language.Portuguese,
                url: "https://link.devtranslate.io/43",
                imageUrl: "https://cdn.devtranslate.io/images/43.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Est Non Quaerat Voluptatem",
                author: "Newton Crist",
                translator: "Wilfrid Aufderhar",
                language: Language.English,
                url: "https://link.devtranslate.io/44",
                imageUrl: "https://cdn.devtranslate.io/images/44.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Articles
            ),
            new Translation(
                title: "Rerum Reprehenderit Voluptatem Omnis Fuga Quia Quis",
                author: "Alphonso Wisoky",
                translator: "Buddy Glover",
                language: Language.English,
                url: "https://link.devtranslate.io/45",
                imageUrl: "https://cdn.devtranslate.io/images/45.png",
                status: TranslationStatus.InProgress,
                type: TranslationType.Documentation
            ),
            new Translation(
                title: "Rerum Et Sit Optio",
                author: "Mateo Bauch",
                translator: "Jamaal Morar",
                language: Language.English,
                url: "https://link.devtranslate.io/46",
                imageUrl: "https://cdn.devtranslate.io/images/46.png",
                status: TranslationStatus.Completed,
                type: TranslationType.Books
            )
        };
    }
}
