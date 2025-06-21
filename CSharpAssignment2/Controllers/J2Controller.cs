using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    [Route("api/J2")]
    [ApiController]
    public class J2Controller : ControllerBase
    {
        // Question 3: Chilli Peppers (CCC J2 Problem)

        /// <summary>
        /// Thsi method calculates the total spiciness of chili based on a list of peppers.
        /// </summary>
        /// <param name="Ingredients">A comma-separated list of pepper names</param>
        /// <returns>
        /// The total Scoville Heat Units (SHU) for the given ingredients
        /// </returns>
        /// <example>
        /// GET: api/J2/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano
        /// Result: 118000
        /// </example>
        /// <example>
        /// GET: api/J2/ChiliPeppers?Ingredients=Habanero,Habanero,Habanero,Habanero,Habanero
        /// Result: 625000
        /// </example>
        /// <example>
        /// GET: api/J2/ChiliPeppers?Ingredients=Poblano,Mirasol,Serrano,Cayenne,Thai,Habanero,Serrano
        /// Result: 278500
        /// </example>
        [HttpGet("ChiliPeppers")]
        public string ChiliPeppers(string Ingredients)
        {
            Dictionary<string, int> pepperSHU = new Dictionary<string, int>()
            {
                { "Poblano", 1500 },
                { "Mirasol", 6000 },
                { "Serrano", 15500 },
                { "Cayenne", 40000 },
                { "Thai", 75000 },
                { "Habanero", 125000 }
            };
            int totalSHU = 0;
            string[] peppers = Ingredients.Split(',', System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string pepper in peppers)
            {
                if (pepperSHU.ContainsKey(pepper.Trim()))
                {
                    totalSHU += pepperSHU[pepper.Trim()];
                }
            }
            return totalSHU.ToString();
        }

        // Question 4: Occupy parking (CCC 2018 J2 Problem)

        /// <summary>
        /// This method ounts how many parking spaces were occupied both yesterday and today.
        /// </summary>
        /// <param name="N">The number of parking spaces</param>
        /// <param name="Yesterday">A string of N characters showing yesterday's parking (C = occupied, . = empty)</param>
        /// <param name="Today">A string of N characters showing today's parking (C = occupied, . = empty)</param>
        /// <returns>
        /// A string representing the number of parking spots that were occupied (C) on both days at the same index.
        /// </returns>
        /// <example>
        /// POST: api/J2/OccupyParking
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: N=5&Yesterday=CC..C&Today=.CC..
        ///
        /// Output:
        /// 1
        /// </example>
        /// <example>
        /// POST: api/J2/OccupyParking
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: N=7&Yesterday=CCCCCCC&Today=C.C.C.C
        ///
        /// Output:
        /// 4
        /// </example>
        [HttpPost("OccupyParking")]
        [Consumes("application/x-www-form-urlencoded")]
        public string OccupyParking([FromForm] int N, [FromForm] string Yesterday, [FromForm] string Today)
        {
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                if (Yesterday[i] == 'C' && Today[i] == 'C')
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}

