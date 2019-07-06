using DevTranslate.Api.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevTranslate.Api.Controllers
{
    [Route("translations")]
    public class TranslationsController : ControllerBase
    {
        private readonly DevTranslateContext _context;

        public TranslationsController(DevTranslateContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SearchTranslations()
        {
            var query = _context.Translations.Select(t => new
            {
                t.Id,
                t.Title,
                t.Author,
                t.Translator,
                t.Language,
                t.Url,
                t.ImageUrl,
                t.Status,
                t.Type
            }).ToList();

            return Ok(query);
        }
    }
}
