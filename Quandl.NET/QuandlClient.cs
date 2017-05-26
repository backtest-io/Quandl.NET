﻿namespace Quandl.NET
{
    public class QuandlClient
    {
        public QuandlClient(string apiKey)
        {
            Database = new DatabaseApi(apiKey);
            Datatable = new DatatableApi(apiKey);
            Dataset = new DatasetApi(apiKey);
            Timeseries = new Timeseries(apiKey);
            Tables = new Tables(apiKey);
        }

        public DatabaseApi Database { get; private set; }

        public DatatableApi Datatable { get; private set; }

        public DatasetApi Dataset { get; private set; }

        public Timeseries Timeseries { get; private set; }

        public Tables Tables { get; private set; }
    }

    public abstract class QuandlApiBase
    {
        protected string _apiKey;

        protected QuandlApiBase(string apiKey)
        {
            _apiKey = apiKey;
        }
    }

    internal static class Constant
    {
        public const string HostUri = "https://www.quandl.com/api/v3";
    }
}