
# Latest Response

## Structure

`LatestResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Base` | `string` | Optional | The currency code you supplied as base in your request |
| `Date` | `string` | Optional | The date these exchange rates are for |
| `Rates` | `Dictionary<string, double>` | Optional | Each supported currency code in terms of the base currency |
| `TimeLastUpdated` | `int?` | Optional | The epoch time this set of exchange rates was generated |

## Example (as JSON)

```json
{
  "base": "USD",
  "time_last_updated": 1556293443,
  "date": "date4",
  "rates": {
    "key0": 101.32,
    "key1": 101.33,
    "key2": 101.34
  }
}
```

