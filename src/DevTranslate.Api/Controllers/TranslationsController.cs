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
        public IActionResult SearchTranslations(string query, int? page = 1, int? recordsPerPage = 10)
        {
            if (!page.HasValue || page.Value < 1)
            {
                page = 1;
            }

            if (!recordsPerPage.HasValue || recordsPerPage.Value < 1 || recordsPerPage.Value > 10)
            {
                recordsPerPage = 10;
            }

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
                databaseQuery = databaseQuery.Where(t => t.Title.Contains(query));
            }

            databaseQuery = databaseQuery.Skip(recordsPerPage.Value * (page.Value - 1))
                                         .Take(recordsPerPage.Value);

            return Ok(databaseQuery.ToList());
        }
    }
}
