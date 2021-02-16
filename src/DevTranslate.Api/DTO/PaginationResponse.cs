using Swashbuckle.AspNetCore.Annotations;
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

        [SwaggerSchema("The number of the page of records to be returned. Defaults to 1.", ReadOnly = false)]
        public int Page { get; }

        [SwaggerSchema("Number of items per page. Can not be higher than 10 which is also its default value.", ReadOnly = false)]
        public int PageSize { get; }

        [SwaggerSchema("Total number of page of records available for the requested page size.", ReadOnly = false)]
        public int TotalPages { get; }
    }
}
