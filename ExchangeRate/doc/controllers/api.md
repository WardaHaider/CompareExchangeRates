# API

```csharp
APIController aPIController = client.APIController;
```

## Class Name

`APIController`


# Latest Exchange Rates

Returns latest exchange rates in parameter-supplied base currency.

```csharp
LatestExchangeRatesAsync(
    string baseCurrency)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `baseCurrency` | `string` | Template, Required | **Base Currency**. *Example: USD*. You an use any of the ISO 4217 currency codes we support. See https://www.exchangerate-api.com/docs/supported-currencies |

## Response Type

[`Task<Models.LatestResponse>`](../../doc/models/latest-response.md)

## Example Usage

```csharp
string baseCurrency = "base_currency0";
try
{
    LatestResponse result = await aPIController.LatestExchangeRatesAsync(baseCurrency);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Currency code not supported | [`Latest404ErrorException`](../../doc/models/latest-404-error-exception.md) |

