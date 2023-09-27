using ExchangeRateAPI.Standard.Controllers;
using ExchangeRateAPI.Standard.Models;
using ImageCharts.Standard;
using ImageCharts.Standard.Controllers;
using ImageCharts.Standard.Exceptions;
using ImageCharts.Standard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Testing
{
    public class Program_Backup
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
            Console.ReadLine();
        }

        static async Task MainAsync()
        {
            //await chart();
            await getRate();
        }
        public static async Task getRate()
        {
            string baseCurrency = "USD";
            string chlVals = "";
            string chdVals = "";
            try
            {
                ExchangeRateAPI.Standard.ExchangeRateAPIClient exchangeRateClient = new ExchangeRateAPI.Standard.ExchangeRateAPIClient.Builder().Build();
                APIController exchangeRateController = exchangeRateClient.APIController;
                LatestResponse result = await exchangeRateController.LatestExchangeRatesAsync(baseCurrency);

                Dictionary<string, double> rateDict = result.Rates;
                List<string> filterKeys = new List<string> { "AFN", "BDT", "INR", "LKR", "MVR", "NPR", "PKR"};
                foreach (var rate in rateDict)
                {
                    if (filterKeys.Contains(rate.Key))
                    {
                        chlVals += rate.Value+"|";
                        chdVals += rate.Value+",";
                        //Console.WriteLine($"Key: {rate.Key}, Value: {rate.Value}");
                    }
                }
                //Console.WriteLine(chlVals);
                chart(chlVals, chdVals);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static async Task chart(string chlVals, string chdVals)
        {
            ImageChartsClient client = new ImageChartsClient.Builder()
                .Build();
            //78.7 | 108.97 | 83 | 324 | 15.55 | 132.83 | 293
            ChartController chartController = client.ChartController;

            ChtEnum cht = ChtEnum.Bvs;
            //string chl = "10|50|60|80|40|50|60|100|40|20";
            string chl = chlVals;
            string chd = "a:"+ chdVals.Substring(0, chdVals.Length - 1);
            string chs = "999x450";
            string chof = ".png";
            string chdl = "N|N-1";
            string chdls = "000000";
            string chco = "27c9b9";
            string chtt = "South Asian Countries";
            string chxt = "x,y";
            string chxl = "0:|AFN|BDT|INR|LKR|MVR|NPR|PKR";
            string chxs = "1N*cUSD0sz*,000000,14";
            string chdlp = "r";
            string chf = "bg,s,FFFFFF";
            string chbh = "5";
            string chbr = "0";
            bool? icwt = false;
            string icqrb = "FFFFFF";
            string icqrf = "000000";

            try
            {
                string currentDirectory = Directory.GetCurrentDirectory();
                string outputPath = Path.Combine(currentDirectory, "output.png");

                dynamic result = await chartController.GetChartAsync(cht, chl, chd, chs, null, null, null, null, null, chof, chdl, chdls, null, chco, chtt, null, chxt, chxl, chxs, null, null, null, null, chdlp, chf, chbh, chbr, null, null, null, null, null, null, null, icwt, null, icqrb, icqrf);

                using (var fileStream = new FileStream(outputPath, FileMode.Create))
                {
                    result.CopyTo(fileStream);
                }

                Console.WriteLine($"Image saved to {outputPath}");
            }
            catch (Exception e)
            {
                // TODO: Handle exception here
                Console.WriteLine(e.Message);
            }
        }
        public static async Task chart2()
        {
            ImageChartsClient client = new ImageChartsClient.Builder()
                .Build();

            ChartJsController chartJsController = client.ChartJsController;

            string c = "{   \"type\": \"bar\",   \"data\": {     \"labels\": [       \"January\",       \"February\",       \"March\",       \"April\",       \"May\",       \"June\",       \"July\"     ],     \"datasets\": [       {         \"label\": \"Dataset 1\",         \"backgroundColor\": \"rgba(255, 99, 132, 0.5)\",         \"borderColor\": \"rgb(255, 99, 132)\",         \"borderWidth\": 1,         \"data\": [           -31,           -70,           -30,           -33,           -9,           14,           -41         ]       },       {         \"label\": \"Dataset 2\",         \"backgroundColor\": \"rgba(54, 162, 235, 0.5)\",         \"borderColor\": \"rgb(54, 162, 235)\",         \"borderWidth\": 1,         \"data\": [           73,           41,           29,           61,           -65,           59,           38         ]       }     ]   },   \"options\": {     \"responsive\": true,     \"legend\": {       \"position\": \"top\"     },     \"title\": {       \"display\": true,       \"text\": \"Chart.js Bar Chart\"     }   } }";
            int? width = 500;
            int? height = 300;
            EncodingEnum? encoding = EncodingEnum.Url;
            try
            {
                await chartJsController.GetChartjs280Async(c, null, width, height, null, null, encoding, null, null, null);
            }
            catch (Exception e)
            {
                // TODO: Handle exception here
                Console.WriteLine(e.Message);
            }
        }
    }
}