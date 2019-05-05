using System.Data;

public interface IExternalApiClient
{
    IStockPriceData GetPriceDataForStock(IStock stock);

    IStockPriceData[] GetPriceDataForStockInRange(IStock stock, TimeSpan range, TimeSpan intervals);
}