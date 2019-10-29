using System;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace save_state.ViewModels
{

    public class AnalysisViewModel
    {

        public PlotModel plotModelGood { get; }
        public PlotModel plotModel { get; }

        public AnalysisViewModel()
        {
            this.plotModelGood = new PlotModel { Title = "A" };

            var xaxis = new CategoryAxis();
            xaxis.Position = AxisPosition.Bottom;
            xaxis.MajorGridlineStyle = LineStyle.Solid;
            xaxis.MinorGridlineStyle = LineStyle.Dot;
            xaxis.Labels.Add("10/06");
            xaxis.Labels.Add("10/07");
            xaxis.Labels.Add("10/08");
            xaxis.Labels.Add("10/09");
            xaxis.Labels.Add("10/10");
            xaxis.Labels.Add("10/11");
            xaxis.Labels.Add("10/12");
            xaxis.FontSize = 8.0;

            var yaxis = new LinearAxis();
            yaxis.Position = AxisPosition.Left;
            yaxis.MajorGridlineStyle = LineStyle.Dot;
            yaxis.MinorGridlineStyle = LineStyle.Dot;

            var columnSeriesGood = new ColumnSeries();
            columnSeriesGood.Items.Add(new ColumnItem(5));
            columnSeriesGood.Items.Add(new ColumnItem(8));
            columnSeriesGood.Items.Add(new ColumnItem(2));
            columnSeriesGood.Items.Add(new ColumnItem(12));
            columnSeriesGood.Items.Add(new ColumnItem(4));
            columnSeriesGood.Items.Add(new ColumnItem(1));
            columnSeriesGood.Items.Add(new ColumnItem(9));

            plotModelGood.Axes.Add(xaxis);
            plotModelGood.Axes.Add(yaxis);
            plotModelGood.Series.Add(columnSeriesGood);


            plotModel = new PlotModel { Title = "B" };


            var xaxisLine = new CategoryAxis();
            xaxisLine.Position = AxisPosition.Bottom;
            xaxisLine.MajorGridlineStyle = LineStyle.Solid;
            xaxisLine.MinorGridlineStyle = LineStyle.Dot;
            xaxisLine.Labels.Add("10/06");
            xaxisLine.Labels.Add("10/07");
            xaxisLine.Labels.Add("10/08");
            xaxisLine.Labels.Add("10/09");
            xaxisLine.Labels.Add("10/10");
            xaxisLine.Labels.Add("10/11");
            xaxisLine.Labels.Add("10/12");
            xaxisLine.FontSize = 8.0;

            var yaxisLine = new LinearAxis();
            yaxisLine.Position = AxisPosition.Left;
            yaxisLine.MajorGridlineStyle = LineStyle.Dot;
            yaxisLine.MinorGridlineStyle = LineStyle.Dot;

            plotModel.Axes.Add(xaxisLine);
            plotModel.Axes.Add(yaxisLine);
            plotModel.Series.Add(new LineSeries
            {
                Points =
                {
                    new DataPoint(0, 2.5),
                    new DataPoint(1, 3.0),
                    new DataPoint(2, 4.8),
                    new DataPoint(3, 2.2),
                    new DataPoint(4, 3.4),
                    new DataPoint(5, 5.0),
                    new DataPoint(6, 1.2),
                }
            });
        }
    }
}
