using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cyberkruz.Autorest.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Cyberkruz.Autorest.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Jokes")]
    public class JokesController : Controller
    {
        [SwaggerOperation(operationId: "GetJokes")]
        [HttpGet("", Name = "GetJokes")]
        [ProducesResponseType(typeof(Joke[]), 200)]
        public IActionResult Get()
        {
            var jokes = new Joke[]
            {
                new Joke()
                {
                    Question = "What do you call a boomerang that won't come back?",
                    Answer = "A stick"
                },
                new Joke()
                {
                    Question = "What horse never comes out in the daytime?",
                    Answer = "A night mare"
                }
            };

            return Ok(jokes);
        }
    }
}