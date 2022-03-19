using DevTranslate.Api.Shared;
using Swashbuckle.AspNetCore.Annotations;
using System;

namespace DevTranslate.Api.DTO
{
    public class PaginationResponse
    {
        public PaginationResponse(Pagination pagination, int totalRecords)
        {
            TotalRecords = totalRecords;
            Page = pagination.Page;
            PageSize = pagination.PageSize;
            TotalPages = Convert.ToInt32(Math.Ceiling(totalRecords / Convert.ToDecimal(pagination.PageSize)));
        }

        [SwaggerSchema("The number of the page of records to be returned. Defaults to 1.", ReadOnly = false)]
        public int Page { get; }

        [SwaggerSchema("Number of items per page. Can not be higher than 10 which is also its default value.", ReadOnly = false)]
        public int PageSize { get; }

        [SwaggerSchema("Total number of page of records available for the requested page size.", ReadOnly = false)]
        public int TotalPages { get; }

        [SwaggerSchema("Total number of records found given the selected filter and pagination settings", ReadOnly = false)]
        public int TotalRecords { get; }
    }
}
