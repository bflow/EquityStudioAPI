using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquityStudioAPI.Utilities
{

    public class MyOptions
    {
        public ApiVendorOptions ApiVendorOptions { get; set; }
    }

    public class ApiVendorOptions
    {
        public AlphaVantage AlphaVantage { get; set; }
        public Quandl Quandl { get; set; }
        public IEXsandbox IEXsandbox { get; set; }
        public IEX Iex { get; set; }
        public Finbox Finbox { get; set; }
    }

    public class AlphaVantage
    {
        public string BaseUrl { get; set; }
        public string Client { get; set; }
        public string Token { get; set; }
        public string DefaultFunction { get; set; }
        public string DefaultRoute { get; set; }
    }

    public class Finbox
    {
        public string BaseUrl { get; set; }
        public string Client { get; set; }
        public string Token { get; set; }
        public string DefaultFunction { get; set; }
        public string DefaultRoute { get; set; }
    }


    public class IEX
    {
        public string BaseUrl { get; set; }
        public string Client { get; set; }
        public string Token { get; set; }
        public string DefaultFunction { get; set; }
        public string DefaultRoute { get; set; }
    }

    public class IEXsandbox
    {
        public string BaseUrl { get; set; }
        public string Client { get; set; }
        public string Token { get; set; }
        public string DefaultFunction { get; set; }
        public string DefaultRoute { get; set; }
    }

    public class Quandl
    {
        public string BaseUrl { get; set; }
        public string Client { get; set; }
        public string Token { get; set; }
        public string DefaultFunction { get; set; }
        public string DefaultRoute { get; set; }
    }
}

