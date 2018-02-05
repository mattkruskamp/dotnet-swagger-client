using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cyberkruz.Autorest.Web.Models
{
    /// <summary>
    /// A full model of a Joke to pull out of the API.
    /// </summary>
    public class Joke
    {
        /// <summary>
        /// The joke's setup question.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// The punchline of the joke.
        /// </summary>
        public string Answer { get; set; }
    }
}
