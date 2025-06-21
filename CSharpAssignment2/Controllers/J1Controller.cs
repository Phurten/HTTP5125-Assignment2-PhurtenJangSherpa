using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class J1Controller : ControllerBase
    {
        // ==========================
        // Question 1: Deliv-e-droid (CCC J1 Problem)
        // ==========================

        /// <summary>
        /// This method calculates the final score in the Deliv-e-droid game.
        /// </summary>
        /// <param name="Collisions">The number of times the droid collided with obstacles</param>
        /// <param name="Deliveries">The number of packages successfully delivered</param>
        /// <returns>
        /// An integer score calculated by: (Deliveries × 50) - (Collisions × 10), plus a bonus of 500 if Deliveries > Collisions
        /// </returns>
        /// <example>
        /// POST: api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: Collisions=2&Deliveries=5
        /// Result: 730
        /// </example>
        /// <example>
        /// POST: api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: Collisions=10&Deliveries=0
        /// Result: -100
        /// </example>
        /// <example>
        /// POST: api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: Collisions=3&Deliveries=2
        /// Result: 70
        /// </example>
        [HttpPost("Delivedroid")]
        public string Delivedroid([FromForm] int Collisions, [FromForm] int Deliveries)
        {
            int score = (Deliveries * 50) - (Collisions * 10);
            if (Deliveries > Collisions)
            {
                score = score + 500;
            }

            return score.ToString();
        }

        // ==========================
        // Question 2: Dog Treats (CCC 2020 J1 Problem)
        // ==========================


        /// <summary>
        /// This method calculates the happiness of the dog based on the number of treats.
        /// </summary>
        /// <param name="Small">The number of small treats (1 point each)</param>
        /// <param name="Medium">The number of medium treats (2 points each)</param>
        /// <param name="Large">The number of large treats (3 points each)</param>
        /// <returns>
        /// Returns "happy" if total points >= 10, otherwise returns "sad"
        /// </returns>
        /// <example>
        /// POST: api/J1/DogTreats
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: Small=3&Medium=1&Large=1
        /// Result: happy
        /// </example>
        /// <example>
        /// POST: api/J1/DogTreats
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: Small=1&Medium=1&Large=1
        /// Result: sad
        /// </example>
        [HttpPost("DogTreats")]
        public string DogTreats([FromForm] int Small, [FromForm] int Medium, [FromForm] int Large)
        {
            int totalPoints = (Small * 1) + (Medium * 2) + (Large * 3);

            if (totalPoints >= 10)
            {
                return "happy";
            }
            else
            {
                return "sad";
            }

        }
    }
}
