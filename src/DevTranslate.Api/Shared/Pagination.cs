using CSharpFunctionalExtensions;

namespace DevTranslate.Api.Shared
{
    public class Pagination
    {
        public const int DefaultPage = 1;
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 10;

        public static Result<Pagination> Create(int? page, int? pageSize)
        {
            if (page <= 0)
                return Result.Failure<Pagination>("Invalid page number");
            if (pageSize <= 0)
                return Result.Failure<Pagination>("Invalid page size");

            int validPage = page ?? DefaultPage;
            int validPageSize = pageSize ?? DefaultPageSize;

            if (validPageSize <= MaxPageSize)
                return new Pagination(validPage, validPageSize);

            return new Pagination(validPage, MaxPageSize);
        }

        private Pagination(int page, int pageSize)
        {
            Page = page;
            PageSize = pageSize;
        }

        public int Page { get; }
        public int PageSize { get; }
    }
}
