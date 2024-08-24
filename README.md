# SlideWindowLogin

![Banner Animation](https://your-animation-url.com/banner.gif)

## Overview

SlideWindowLogin is a Web API project that demonstrates the implementation of a sliding window algorithm for rate limiting login attempts. This technique helps prevent brute force attacks by controlling the number of login attempts a user can make in a given time window.

![Overview Animation](https://your-animation-url.com/overview.gif)

## Features

- **Sliding window rate limiting for login attempts**
- **Secure login API**
- **In-memory data storage for tracking login attempts**

![Features Animation](https://your-animation-url.com/features.gif)

## Getting Started

### Prerequisites

- **.NET Core SDK** (version 6.0 or later)

### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/maduradevDotNet/SlideWindowLogin.git
    ```

    ![Clone Repo Animation](https://your-animation-url.com/clone-repo.gif)

2. **Navigate to the project directory:**

    ```bash
    cd SlideWindowLogin
    ```

3. **Restore the project dependencies:**

    ```bash
    dotnet restore
    ```

4. **Run the application:**

    ```bash
    dotnet run
    ```

    ![Run App Animation](https://your-animation-url.com/run-app.gif)

## Usage

- **POST /api/login**  
  Attempt to log in with a username and password. The request will be rate-limited based on the sliding window algorithm.

![Usage Animation](https://your-animation-url.com/usage.gif)

## Example Request

- **Login Attempt**

    ```bash
    curl -X POST "https://localhost:5001/api/login" -H "Content-Type: application/json" -d '{"username": "user", "password": "pass"}'
    ```

    ![Login Attempt Animation](https://your-animation-url.com/login-attempt.gif)

## Configuration

- **Rate Limiting Settings:** Configure the sliding window parameters in the `appsettings.json` file under the `RateLimiting` section. This includes settings like the time window duration and the maximum number of attempts allowed.

    ![Configuration Animation](https://your-animation-url.com/configuration.gif)

## Contributing

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Create a Pull Request.

![Contributing Animation](https://your-animation-url.com/contributing.gif)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

![License Animation](https://your-animation-url.com/license.gif)
