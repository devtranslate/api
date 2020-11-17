using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.DTO
{
    public class PaginationResponse
    {
        private readonly int _totalRecords;

        public PaginationResponse(int page, int pageSize, int totalRecords)
        {
            if (page < 1)
            {
                page = 1;
            }

            if (pageSize < 1 || pageSize > 10)
            {
                pageSize = 10;
            }

            _totalRecords = totalRecords;

            Page = page;
            PageSize = pageSize;
            TotalPages = Convert.ToInt32(Math.Ceiling(totalRecords / (pageSize * 1.0m)));
        }

        public int Page { get; }
        public int PageSize { get; }
        public int TotalPages { get; }
    }
}
