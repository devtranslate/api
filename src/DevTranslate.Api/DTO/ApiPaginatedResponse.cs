using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.DTO
{
    public abstract class ApiPaginatedResponse
    {
        public PaginationResponse Pagination { get; set; }
    }
}
