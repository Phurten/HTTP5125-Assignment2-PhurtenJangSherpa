using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace YourNamespace.Controllers
{
    [Route("api/J3")]
    [ApiController]
    public class J3Controller : ControllerBase
    {
        // Question 5: Are we there yet? (CCC 2018 J3 Problem)

        /// <summary>
        /// This method generates a distance table for 5 cities based on distances between consecutive cities.
        /// </summary>
        /// <param name="D1">Distance between city 1 and city 2</param>
        /// <param name="D2">Distance between city 2 and city 3</param>
        /// <param name="D3">Distance between city 3 and city 4</param>
        /// <param name="D4">Distance between city 4 and city 5</param>
        /// <returns>
        /// A multiline string where each line i (1-indexed) contains the distances from city i to cities 1 to 5, space-separated.
        /// </returns>
        /// <example>
        /// POST: api/J3/DistanceTable
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: D1=3&D2=10&D3=12&D4=5
        /// 
        /// Output:
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// </example>
        [HttpPost("DistanceTable")]
        [Consumes("application/x-www-form-urlencoded")]
        public string DistanceTable([FromForm] int D1, [FromForm] int D2, [FromForm] int D3, [FromForm] int D4)
        {
            int[] distances = new int[] { D1, D2, D3, D4 };
            int[] cumulative = new int[5]; 

            for (int i = 1; i < 5; i++)
            {
                cumulative[i] = cumulative[i - 1] + distances[i - 1];
            }

            string result = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    result += Math.Abs(cumulative[j] - cumulative[i]) + (j < 4 ? " " : "");
                }
                result += "\n";
            }

            return result.Trim(); 
        }
    }
}
