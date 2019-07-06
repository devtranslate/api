using DevTranslate.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevTranslate.Api.Context
{
    public static class DevTranslateSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                new
                {
                    Id = 1,
                    Title = "Pare de usar CSS no JavaScript para desenvolvimento web",
                    Author = "Gajus Kuizinas",
                    Translator = "Carlos Eduardo Olivieri",
                    Language = Language.English,
                    Url = "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                    ImageUrl = "https://image.ibb.co/b9GdKb/1.png",
                    Status = Status.Completed,
                    TranslationType = TranslationType.Articles
                }
            );
        }
    }
}
