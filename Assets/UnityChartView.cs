using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Definitions.Series;
using LiveCharts.Dtos;
using LiveCharts.Events;

internal class UnityChartView : ICartesianChart
{
    public UnityChartView()
    {
    }

    public ChartCore Model => throw new NotImplementedException();

    public SeriesCollection Series { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public IEnumerable<ISeriesView> ActualSeries => throw new NotImplementedException();

    public TimeSpan TooltipTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public ZoomingOptions Zoom { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public PanningOptions Pan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double ZoomingSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public LegendLocation LegendLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool DisableAnimations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public TimeSpan AnimationsSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public UpdaterState UpdaterState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public bool HasTooltip => throw new NotImplementedException();

    public bool HasDataClickEventAttached => throw new NotImplementedException();

    public bool HasDataHoverEventAttached => throw new NotImplementedException();

    public bool Hoverable => throw new NotImplementedException();

    public bool IsControlLoaded => throw new NotImplementedException();

    public bool IsInDesignMode => throw new NotImplementedException();

    public VisualElementsCollection VisualElements { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event DataClickHandler DataClick;
    public event DataHoverHandler DataHover;

    public void AddToDrawMargin(object element)
    {
        throw new NotImplementedException();
    }

    public void AddToView(object element)
    {
        throw new NotImplementedException();
    }

    public void EnsureElementBelongsToCurrentDrawMargin(object element)
    {
        throw new NotImplementedException();
    }

    public void EnsureElementBelongsToCurrentView(object element)
    {
        throw new NotImplementedException();
    }

    public void HideLegend()
    {
        throw new NotImplementedException();
    }

    public void HideTooltip()
    {
        throw new NotImplementedException();
    }

    public CoreSize LoadLegend()
    {
        throw new NotImplementedException();
    }

    public List<AxisCore> MapXAxes(ChartCore chart)
    {
        throw new NotImplementedException();
    }

    public List<AxisCore> MapYAxes(ChartCore chart)
    {
        throw new NotImplementedException();
    }

    public void RemoveFromDrawMargin(object element)
    {
        throw new NotImplementedException();
    }

    public void RemoveFromView(object element)
    {
        throw new NotImplementedException();
    }

    public void SetDrawMarginHeight(double value)
    {
        throw new NotImplementedException();
    }

    public void SetDrawMarginLeft(double value)
    {
        throw new NotImplementedException();
    }

    public void SetDrawMarginTop(double value)
    {
        throw new NotImplementedException();
    }

    public void SetDrawMarginWidth(double value)
    {
        throw new NotImplementedException();
    }

    public void ShowLegend(CorePoint at)
    {
        throw new NotImplementedException();
    }
}