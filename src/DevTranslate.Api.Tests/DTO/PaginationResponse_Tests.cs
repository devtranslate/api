using DevTranslate.Api.DTO;
using DevTranslate.Api.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevTranslate.Api.Tests.DTO
{
    public class PaginationResponse_Tests
    {
        [Theory]
        [InlineData(10, 46, 5)]
        [InlineData(5, 46, 10)]
        [InlineData(10, 40, 4)]
        [InlineData(9, 46, 6)]
        public void Should_CalculateNumberOfPages_When_Instantiated(int pageSize, int totalRecords, int totalPages)
        {
            var paginationResult = Pagination.Create(1, pageSize);
            var paginationResponse = new PaginationResponse(paginationResult.Value, totalRecords);

            Assert.Equal(totalPages, paginationResponse.TotalPages);
        }
    }
}
