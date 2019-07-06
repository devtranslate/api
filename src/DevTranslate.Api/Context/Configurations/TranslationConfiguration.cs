using DevTranslate.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevTranslate.Api.Context.Configurations
{
    public class TranslationConfiguration : IEntityTypeConfiguration<Translation>
    {
        public void Configure(EntityTypeBuilder<Translation> builder)
        {
            builder.ToTable("translations");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                .HasColumnName("id");

            builder.Property(t => t.Title)
                .HasColumnName("title")
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(t => t.Author)
                .HasColumnName("author")
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(t => t.Translator)
                .HasColumnName("translator")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(t => t.Language)
                .HasColumnName("language");

            builder.Property(t => t.Url)
                .HasColumnName("url")
                .IsRequired();

            builder.Property(t => t.ImageUrl)
                .HasColumnName("imageUrl")
                .IsRequired();

            builder.Property(t => t.Status)
                .HasColumnName("status");

            builder.Property(t => t.Type)
                .HasColumnName("type");
        }
    }
}
