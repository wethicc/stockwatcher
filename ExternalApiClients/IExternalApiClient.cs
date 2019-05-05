using System;
using System.Threading.Tasks;

public interface IExternalApiClient
{
    Task<IStockPriceData> GetPriceDataForStock(IStock stock);

    Task<IStockPriceData[]> GetPriceDataForStockInRange(IStock stock, TimeSpan range, TimeSpan intervals);
}