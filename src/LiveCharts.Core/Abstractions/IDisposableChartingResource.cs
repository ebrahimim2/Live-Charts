namespace LiveCharts.Core.Abstractions
{
    /// <summary>
    /// A resource able to erase itself from memory and/or a chart view.
    /// </summary>
    public interface IDisposableChartingResource
    {
        /// <summary>
        /// Disposes from specified view.
        /// </summary>
        /// <param name="view">The view.</param>
        void Dispose(IChartView view);
    }
}