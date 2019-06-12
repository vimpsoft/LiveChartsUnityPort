using LiveCharts;
using LiveCharts.Charts;
using UnityEngine;

public class Test : MonoBehaviour
{
    private ChartUpdater _updater = new ChartUpdater();
    private UnityChartView _view = new UnityChartView();
    private CartesianChartCore _chart;

    public void Test1()
    {
        var chart = new CartesianChartCore(_view, _updater);
        //_view.ActualSeries
    }

    private void Update()
    {
        //_updater.UpdateFrequency
    }
}
