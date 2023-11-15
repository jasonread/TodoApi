# .NET 6 Web API
This repo contains a sample .NET 6 Web API demonstrating a basic implementation of JWT authentication.

## How to use

1. POST the following JSON payload to `/api/login` to generate a JWT
```json
{
    "Username": "<your-user-name>",
    "Password": "<your-password>"
}
```
2. Use this JWT in subsequent requests to `/api/todoitems` endpoints
