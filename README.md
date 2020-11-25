# RazorMVC

This is a project to show how to consume Blazor components in an existing
ASP.NET Core MVC project that uses Authentication.

The goal is to be able to create and save items for a given user and displayed them
using Blazor.

## Getting Started

This project uses AzureAD as the authentication source. Configure AzureAD as follows:

- Create a new App Registration in AzureAD
- **Authentication tab**
  - Set up https://localhost:5001/signin-oidc as a Redirect URI
  - Enable ID tokens
- **Certificates and secrets tab**
  - Create a new client secret and copy the secret value

Run the following CLI commands to configure Azure AD in the application:

```ps
# get from Overview tab for your AzureAd app reg
dotnet user-secrets set "AzureAd:TenantId" "_INSERT VALUE_"
dotnet user-secrets set "AzureAd:ClientId" "_INSERT VALUE_"

# the secret you copied in the previous step
dotnet user-secrets set "AzureAd:ClientSecret" "_INSERT VALUE_"
```
