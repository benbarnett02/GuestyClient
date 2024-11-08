# Guesty Open API Client (C#)

This is a C# client for the Guesty Open API. It is a simple wrapper around the API, providing strongly-typed objects for all the API endpoints.

**Work in progress.**

## Usage

```csharp
var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {Your API Token}");
httpClient.BaseAddress = new Uri("https://open-api.guesty.com/v1/");
var guestyClient = new GuestyClient(httpClient);

// Make some requests.
Listing listing = await guestyClient.GetListing("my-listings-id");
```

## Installation
It's not on NuGet yet, so you'll have to clone the repo and build it yourself. Have fun!

## Contributing
Pull requests are welcome. No guarantees.

## Warranty etc
This is not an official Guesty product, nor is professional support/warranty provided in any way. Use at your own risk. 
This is a work in progress and is not feature complete **AT ALL**.