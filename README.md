SlideWindowLogin
Overview
SlideWindowLogin is a Web API project that demonstrates the implementation of a sliding window algorithm for rate limiting login attempts. This technique helps prevent brute force attacks by controlling the number of login attempts a user can make in a given time window.

Features
Sliding window rate limiting for login attempts
Secure login API
In-memory data storage for tracking login attempts
Getting Started
Prerequisites
.NET Core SDK (version 6.0 or later)
Installation
Clone the repository:

bash
Copy code
git clone https://github.com/maduradevDotNet/SlideWindowLogin.git
Navigate to the project directory:

bash
Copy code
cd SlideWindowLogin
Restore the project dependencies:

bash
Copy code
dotnet restore
Run the application:

bash
Copy code
dotnet run
Usage
POST /api/login
Attempt to log in with a username and password. The request will be rate-limited based on the sliding window algorithm.
Example Request
Login Attempt

bash
Copy code
curl -X POST "https://localhost:5001/api/login" -H "Content-Type: application/json" -d '{"username": "user", "password": "pass"}'
Configuration
Rate Limiting Settings: Configure the sliding window parameters in the appsettings.json file under the RateLimiting section. This includes settings like the time window duration and the maximum number of attempts allowed.
Contributing
Fork the repository.
Create a feature branch (git checkout -b feature/YourFeature).
Commit your changes (git commit -am 'Add new feature').
Push to the branch (git push origin feature/YourFeature).
Create a Pull Request.
License
This project is licensed under the MIT License - see the LICENSE file for details.
