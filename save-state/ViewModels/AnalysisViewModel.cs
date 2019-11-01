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
        public PlotModel plotModelComposite { get; }

        public AnalysisViewModel()
        {
            this.plotModelGood = new PlotModel { Title = "A" }; //良かったこと

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
            yaxis.FontSize = 8.0;

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

            plotModel = new PlotModel { Title = "B" }; //気分

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
            yaxisLine.FontSize = 8.0;

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

            plotModelComposite = new PlotModel { Title = "C" }; // 複合

            var xaxisComposite = new CategoryAxis();
            xaxisComposite.Position = AxisPosition.Bottom;
            xaxisComposite.MajorGridlineStyle = LineStyle.Solid;
            xaxisComposite.MinorGridlineStyle = LineStyle.Dot;
            xaxisComposite.Labels.Add("10/06");
            xaxisComposite.Labels.Add("10/07");
            xaxisComposite.Labels.Add("10/08");
            xaxisComposite.Labels.Add("10/09");
            xaxisComposite.Labels.Add("10/10");
            xaxisComposite.Labels.Add("10/11");
            xaxisComposite.Labels.Add("10/12");
            xaxisComposite.FontSize = 8.0;

            var yaxisComposite1 = new LinearAxis();
            yaxisComposite1.Position = AxisPosition.Left;
            yaxisComposite1.MajorGridlineStyle = LineStyle.None;
            yaxisComposite1.MinorGridlineStyle = LineStyle.None;
            yaxisComposite1.Key = "1";
            yaxisComposite1.FontSize = 8.0;

            var yaxisComposite2 = new LinearAxis();
            yaxisComposite2.Position = AxisPosition.Right;
            yaxisComposite2.Maximum = 5;
            yaxisComposite2.Minimum = 0;
            yaxisComposite2.MajorGridlineStyle = LineStyle.None;
            yaxisComposite2.MinorGridlineStyle = LineStyle.None;
            yaxisComposite2.Key = "2";
            yaxisComposite2.FontSize = 8.0;

            var columnSeriesComposite = new ColumnSeries();
            columnSeriesComposite.Items.Add(new ColumnItem(5));
            columnSeriesComposite.Items.Add(new ColumnItem(8));
            columnSeriesComposite.Items.Add(new ColumnItem(2));
            columnSeriesComposite.Items.Add(new ColumnItem(12));
            columnSeriesComposite.Items.Add(new ColumnItem(4));
            columnSeriesComposite.Items.Add(new ColumnItem(1));
            columnSeriesComposite.Items.Add(new ColumnItem(9));

            plotModelComposite.Axes.Add(xaxisComposite);
            plotModelComposite.Axes.Add(yaxisComposite1);
            plotModelComposite.Axes.Add(yaxisComposite2);
            columnSeriesComposite.YAxisKey = "1";
            plotModelComposite.Series.Add(columnSeriesComposite);
            plotModelComposite.Series.Add(new LineSeries
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
                },
                YAxisKey = "2"
            });


        }
    }
}
