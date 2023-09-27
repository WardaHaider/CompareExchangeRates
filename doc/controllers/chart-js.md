# Chart Js

```csharp
ChartJsController chartJsController = client.ChartJsController;
```

## Class Name

`ChartJsController`


# Get Chartjs 280

Image-charts

```csharp
GetChartjs280Async(
    string c = null,
    string chart = null,
    int? width = 500,
    int? height = 300,
    string backgroundColor = null,
    string bkg = null,
    Models.EncodingEnum? encoding = Models.EncodingEnum.Url,
    string icac = null,
    string ichm = null,
    Models.IcretinaEnum? icretina = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `c` | `string` | Query, Optional | Javascript/JSON definition of the chart. Use a Chart.js configuration object. |
| `chart` | `string` | Query, Optional | Javascript/JSON definition of the chart. Use a Chart.js configuration object. |
| `width` | `int?` | Query, Optional | Width of the chart<br>**Default**: `500`<br>**Constraints**: `>= 1` |
| `height` | `int?` | Query, Optional | Height of the chart<br>**Default**: `300`<br>**Constraints**: `>= 1` |
| `backgroundColor` | `string` | Query, Optional | Background of the chart canvas. Accepts rgb (rgb(255,255,120)), colors (red), and url-encoded hex values (%23ff00ff). Abbreviated as "bkg" |
| `bkg` | `string` | Query, Optional | Background of the chart canvas. Accepts rgb (rgb(255,255,120)), colors (red), and url-encoded hex values (%23ff00ff). Abbreviated as "bkg" |
| `encoding` | [`EncodingEnum?`](../../doc/models/encoding-enum.md) | Query, Optional | Encoding of your "chart" parameter. Accepted values are url and base64.<br>**Default**: `EncodingEnum.url` |
| `icac` | `string` | Query, Optional | image-charts enterprise `account_id` |
| `ichm` | `string` | Query, Optional | HMAC-SHA256 signature required to activate paid features |
| `icretina` | [`IcretinaEnum?`](../../doc/models/icretina-enum.md) | Query, Optional | retina mode |

## Response Type

`Task`

## Example Usage

```csharp
int? width = 500;
int? height = 300;
EncodingEnum? encoding = EncodingEnum.Url;
try
{
    await chartJsController.GetChartjs280Async(null, null, width, height, null, null, encoding, null, null, null);
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
| Default | Successful | `ApiException` |

