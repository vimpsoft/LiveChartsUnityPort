using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Definitions.Series;
using LiveCharts.Dtos;
using LiveCharts.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Chart : FrameworkElement, IChartView
{
    #region Events

    /// <summary>
    /// The DataClick event is fired when a user click any data point
    /// </summary>
    public event DataClickHandler DataClick;

    /// <summary>
    /// The DataHover event is fired when a user hovers over any data point
    /// </summary>
    public event DataHoverHandler DataHover;

    /// <summary>
    /// This event is fired every time the chart updates.
    /// </summary>
    public event UpdaterTickHandler UpdaterTick;

    #endregion

    #region Emulated


    /// <summary>
    /// Gets or sets the chart current canvas
    /// </summary>
    protected readonly ICanvas _canvas;

    internal readonly ICanvas _drawMargin;
    internal readonly IPopup _tooltipContainer;

    #endregion

    #region Utility rewritten

    public TimeSpan AnimationsSpeedProperty { get; private set; }
    public TimeSpan TooltipTimeoutProperty { get; private set; }

    #endregion

    public Chart(ICanvas canvas, ICanvas drawMargin, IPopup tooltipContainer)
    {
        _canvas = canvas;
        _drawMargin = drawMargin;
        _tooltipContainer = tooltipContainer;

        _canvas.AddChildren(_drawMargin);

        MinHeightProperty = 50;
        MinWidthProperty = 80;

        AnimationsSpeedProperty = TimeSpan.FromMilliseconds(300);
        TooltipTimeoutProperty = TimeSpan.FromMilliseconds(800);

        AxisXProperty = new AxesCollection();
    }

    /// <summary>
    /// Chart core model, the model calculates the chart.
    /// </summary>
    protected ChartCore ChartCoreModel;


    public ChartCore Model => ChartCoreModel;

    public SeriesCollection Series { get; set; }

    public IEnumerable<ISeriesView> ActualSeries
    {
        get
        {
            return (Series ?? Enumerable.Empty<ISeriesView>())
                .Where(x => x.IsSeriesVisible);
        }
    }

    public TimeSpan TooltipTimeout { get; set; }
    public ZoomingOptions Zoom { get; set; }
    public PanningOptions Pan { get; set; }
    public double ZoomingSpeed { get; set; }
    public LegendLocation LegendLocation { get; set; }
    public bool DisableAnimations { get; set; }
    public TimeSpan AnimationsSpeed { get; set; }
    public UpdaterState UpdaterState { get; set; }

    /// <summary>
    /// Gets or sets the chart data tooltip.
    /// </summary>
    public string DataTooltip { get; set; }

    /// <summary>
    /// Gets whether the chart has an active tooltip.
    /// </summary>
    public bool HasTooltip => !string.IsNullOrEmpty(DataTooltip);

    /// <summary>
    /// Gets whether the chart has a DataClick event attacked.
    /// </summary>
    public bool HasDataClickEventAttached => DataClick != null;

    /// <summary>
    /// Gets whether the chart has a DataHover event attached
    /// </summary>
    public bool HasDataHoverEventAttached => DataHover != null;

    /// <summary>
    /// Gets whether the chart is already loaded in the view.
    /// </summary>
    public bool IsControlLoaded { get; private set; }

    public bool Hoverable { get; set; }
    
    /// <summary>
    /// Gets whether the control is in design mode
    /// </summary>
    public bool IsInDesignMode { get; private set; } = true;

    public void AddToDrawMargin(object element)
    {
        Debug.Log($"AddToDrawMargin: {element}, type = {element.GetType().FullName}");
    }

    public void AddToView(object element)
    {
        Debug.Log($"AddToView: {element}, type = {element.GetType().FullName}");
    }

    public void EnsureElementBelongsToCurrentDrawMargin(object element)
    {
        Debug.Log($"EnsureElementBelongsToCurrentDrawMargin: {element}, type = {element.GetType().FullName}");
    }

    public void EnsureElementBelongsToCurrentView(object element)
    {
        Debug.Log($"EnsureElementBelongsToCurrentView: {element}, type = {element.GetType().FullName}");
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
        Debug.Log($"RemoveFromDrawMargin: {element}, type = {element.GetType().FullName}");
    }

    public void RemoveFromView(object element)
    {
        Debug.Log($"RemoveFromView: {element}, type = {element.GetType().FullName}");
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
