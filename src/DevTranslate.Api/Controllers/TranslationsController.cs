using DevTranslate.Api.Context;
using DevTranslate.Api.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IActionResult SearchTranslations(string query, int? page = 1, int? pageSize = 10)
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

            if (!String.IsNullOrWhiteSpace(query))
            {
                databaseQuery = databaseQuery.Where(t => t.Title.Contains(query) || t.Author.Contains(query) || t.Translator.Contains(query));
            }

            var pagination = new PaginationResponse(page ?? 0, pageSize ?? 0, databaseQuery.Count());

            databaseQuery = databaseQuery.Skip(pagination.PageSize * (pagination.Page - 1))
                                         .Take(pagination.PageSize);

            var response = new SearchTranslationResponse(databaseQuery, pagination);

            return Ok(response);
        }
    }
}
