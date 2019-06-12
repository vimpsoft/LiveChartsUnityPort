using LiveCharts;
using LiveCharts.Charts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Dtos;

public class Axis : FrameworkElement, IAxisView
{
    public AxisCore Model { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public bool DisableAnimations { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public bool ShowLabels { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double MaxValue { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double MinValue { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double MinRange { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double MaxRange { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double LabelsRotation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public bool IsMerged { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double Unit { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public double BarUnit { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public double PreviousMaxValue => throw new System.NotImplementedException();

    public double PreviousMinValue => throw new System.NotImplementedException();

    public AxisOrientation AxisOrientation => throw new System.NotImplementedException();

    public AxisCore AsCoreElement(ChartCore chart, AxisOrientation source)
    {
        throw new System.NotImplementedException();
    }

    public void Clean()
    {
        throw new System.NotImplementedException();
    }

    public CoreSize GetLabelSize()
    {
        throw new System.NotImplementedException();
    }

    public double GetTileTop()
    {
        throw new System.NotImplementedException();
    }

    public double GetTitleLeft()
    {
        throw new System.NotImplementedException();
    }

    public void RenderSeparator(SeparatorElementCore model, ChartCore chart)
    {
        throw new System.NotImplementedException();
    }

    public void SetRange(double min, double max)
    {
        throw new System.NotImplementedException();
    }

    public void SetTitleLeft(double value)
    {
        throw new System.NotImplementedException();
    }

    public void SetTitleTop(double value)
    {
        throw new System.NotImplementedException();
    }

    public CoreSize UpdateTitle(ChartCore chart, double rotationAngle = 0)
    {
        throw new System.NotImplementedException();
    }
}