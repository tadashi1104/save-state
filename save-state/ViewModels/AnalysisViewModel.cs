using System;
using OxyPlot;
using OxyPlot.Series;

namespace save_state.ViewModels
{

    public class AnalysisViewModel
    {
        public PlotModel plotModel { get; }

        public AnalysisViewModel()
        {
            this.plotModel = new PlotModel { Title = "Hello OxyPlot" };
            this.plotModel.Series.Add(new LineSeries
            {
                Points =
                {
                    new DataPoint(0, 10),
                    new DataPoint(1, 20),
                    new DataPoint(2, 15),
                    new DataPoint(3, 40),
                }
            });
        }
    }
}
