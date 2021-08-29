using DevTranslate.Api.Context;
using DevTranslate.Api.DTO;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevTranslate.Api.Controllers
{
    [ApiController]
    [Route("translations")]
    public class TranslationsController : ControllerBase
    {
        private readonly DevTranslateContext _context;

        public TranslationsController(DevTranslateContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        [SwaggerResponse(200, "List of translations", typeof(SearchTranslationResponse))]
        [SwaggerOperation(
            Summary = "Get a list of translations",
            Description = "Get a paginated list of translations, optionally filtering by title, author or translator",
            OperationId = "SearchTranslations",
            Tags = new[] { "Translations" }
        )]
        [Produces(MediaTypeNames.Application.Json)]
        public IActionResult SearchTranslations([FromQuery] SearchTranslationRequest request)
        {
            var databaseQuery = _context.Translations.Select(t => new SearchTranslationResult()
            {
                Id = t.Id,
                Title = t.Title,
                Author = t.Author,
                Translator = t.Translator,
                Language = t.Language,
                Url = t.Url,
                ImageUrl = t.ImageUrl,
                Status = t.Status,
                Type = t.Type
            });

            if (!String.IsNullOrWhiteSpace(request.Query))
            {
                databaseQuery = databaseQuery.Where(t => t.Title.ToLower().Contains(request.Query.ToLower())
                    || t.Author.ToLower().Contains(request.Query.ToLower())
                    || t.Translator.ToLower().Contains(request.Query.ToLower()));
            }

            if (request.Status.HasValue)
            {
                databaseQuery = databaseQuery.Where(t => t.Status == request.Status.Value);
            }

            var pagination = new PaginationResponse(request.Page ?? 0, request.PageSize ?? 0, databaseQuery.Count());

            databaseQuery = databaseQuery.Skip(pagination.PageSize * (pagination.Page - 1))
                                         .Take(pagination.PageSize);

            var response = new SearchTranslationResponse(databaseQuery, pagination);

            return Ok(response);
        }
    }
}
