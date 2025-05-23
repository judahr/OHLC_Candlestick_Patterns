# Examples Fibonacci

```cs
string json = string.Empty;
ISignals _signals = new Signals();
IAccuracyTrials _accuracy = new AccuracyTrials();
var client = new HttpClient();
var url = "https://gist.github.com/przemyslawbak/92c3d4bba27cfd2b88d0dd916bbdad14/raw/AAL_1min.json";

using (HttpResponseMessage response = await client.GetAsync(url))
{
    using (HttpContent content = response.Content)
    {
        json = content.ReadAsStringAsync().Result;
    }
}

var settings = new JsonSerializerSettings
{
    NullValueHandling = NullValueHandling.Ignore,
    MissingMemberHandling = MissingMemberHandling.Ignore
};

var dataOhlcv = JsonConvert.DeserializeObject<List<OhlcvObject>>(json, settings)
    .Select(x => new OhlcvObject()
    {
        Open = x.Open,
        High = x.High,
        Low = x.Low,
        Close = x.Close,
        Volume = x.Volume,
    })
    .Where(x => x.Open != 0 && x.High != 0 && x.Low != 0 && x.Close != 0)
    .ToList();

//ACCURACY TRIALS
var accuracyPercentageSummary = _accuracy.GetAverPercentAccuracy(dataOhlcv, "Bullish 3 Inside Up");
Console.WriteLine("Accuracy percentage summary comparing to end of data set result: {0}", accuracyPercentageSummary.AccuracyToEndClose);
Console.WriteLine("Accuracy percentage summary comparing to average close result: {0}", accuracyPercentageSummary.AccuracyToAverageClose);

var accuracyForSelectedFibo30CandlesAhead = _accuracy.GetAverPercentAccuracy(dataOhlcv, "Bullish 3 Inside Up", 30);
Console.WriteLine("Accuracy percentage summary 30 candles ahead comparing to end of data set result: {0}", accuracyForSelectedFibo30CandlesAhead.AccuracyToEndClose);
Console.WriteLine("Accuracy percentage summary 30 candles ahead comparing to average close result: {0}", accuracyForSelectedFibo30CandlesAhead.AccuracyToAverageClose);

var accuracyAverPositive = _accuracy.GetPositiveAccuracyToAverFibos(dataOhlcv);
Console.WriteLine("Fibos with positive accuracy rate comaring to aver. close price: {0}", string.Join(",", accuracyAverPositive));

var accuracyEndPositive = _accuracy.GetPositiveAccuracyToEndFibos(dataOhlcv);
Console.WriteLine("Fibos with positive accuracy rate comaring to end close price: {0}", string.Join(",", accuracyEndPositive));

var accuracyBest = _accuracy.GetBestAccuracyFibos(dataOhlcv, 25);
Console.WriteLine("25% of best fibos comparing to end and aver. close price: {0}", string.Join(",", accuracyBest));

var accuracyBest30CandlesAhead = _accuracy.GetBestAccuracyFibos(dataOhlcv, 25, 30);
Console.WriteLine("25% of best fibos 30 candles ahead comparing to end and aver. close price: {0}", string.Join(",", accuracyBest30CandlesAhead));

//SIGNALS
var bullishCount = _signals.GetFiboBullishSignalsCount(dataOhlcv);
Console.WriteLine("Bullish signals count: {0}", bullishCount);

var bearishCount = _signals.GetFiboBearishSignalsCount(dataOhlcv);
Console.WriteLine("Bearish signals count: {0}", bearishCount);

var signalsCountMulti = _signals.GetMultipleFiboSignalsCount(dataOhlcv, new string[] { "BearishABCD", "Bearish 3 Drive" });
Console.WriteLine("Multiple fibo signals count: {0}", signalsCountMulti);

var signalsCountSingle = _signals.GetFibonacciSignalsCount(dataOhlcv, "BearishABCD");
Console.WriteLine("Signals count for Bearish Double Tops: {0}", signalsCountSingle);

var signalsCountMultiWeightened = _signals.GetMultipleFiboSignalsIndex(dataOhlcv, new Dictionary<string, decimal>() { { "BearishABCD", 0.5M }, { "Bearish 3 Drive", 0.5M } });
Console.WriteLine("Weightened index for selected multiple fibo: {0}", signalsCountMultiWeightened);

var signalsCountSingleWeightened = _signals.GetFiboSignalsIndex(dataOhlcv, "BearishABCD", 0.5M);
Console.WriteLine("Weightened index for selected single fibo: {0}", signalsCountSingleWeightened);

var zigZagSingleSignals = _signals.GetFiboZigZagWithSignals(dataOhlcv, "BearishABCD");
Console.WriteLine("Signals for single fibo: {0}", zigZagSingleSignals.Where(x => x.Signal == true).Count());

var zigZagMultiSignals = _signals.GetMultipleFiboZigZagWithSignals(dataOhlcv, new string[] { "BearishABCD", "Bearish 3 Drive" });
Console.WriteLine("Number of lists returned: {0}", zigZagMultiSignals.Count());

//END
Console.WriteLine("END");
Console.ReadLine();
```
