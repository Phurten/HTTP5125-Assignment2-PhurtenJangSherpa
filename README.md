## Assignment Name: C# Assignment 2

## Name: Phurten Jang Sherpa

## Tasks

- [✔] ## Question 1 – Deliv-e-droid (CCC J1)

      POST http://localhost:5023/api/J1/Delivedroid

      Returns the final score in the Deliv-e-droid game based on deliveries and collisions.
      Adds 500-point bonus if deliveries > collisions.

- [✔] ## Question 2 – Dog Treats (CCC 2020 J1)

      POST http://localhost:5023/api/J1/DogTreats

      Returns "happy" or "sad" based on total points from treat counts:
      Small = 1 pt, Medium = 2 pts, Large = 3 pts. Happy if points ≥ 10.

- [✔] ## Question 3 – Chili Peppers (CCC 2023 J2)

      GET http://localhost:5023/api/J2/ChiliPeppers?Ingredients={comma-separated}

      Returns the total Scoville Heat Units (SHU) for the listed pepper ingredients.

- [✔] ## Question 4 – Occupy Parking (CCC 2018 J2)

      POST http://localhost:5023/api/J2/OccupyParking

      Returns the number of parking spots occupied ('C') on both days in the same position.

- [✔] ## Question 5 – Are We There Yet? (CCC 2018 J3)

      POST http://localhost:5023/api/J3/DistanceTable

      Returns a 5×5 distance table matrix between 5 cities, based on user-entered distances
      between consecutive cities (D1, D2, D3, D4).

## Learning curve and challenges

- Handling HTTP input formats (query vs form-urlencoded)
- Converting terminal input logic into web API endpoints
- Maintaining consistent <summary> XML documentation
- Properly formatting multiline string responses (e.g., for distance matrices)

## Resources

- Class Lectures  
- Class Exercises  
- https://learn.microsoft.com/en-us/dotnet/?view=net-8.0  
- CCC Problem Set – https://cemc.uwaterloo.ca/
