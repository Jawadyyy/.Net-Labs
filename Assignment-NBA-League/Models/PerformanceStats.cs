namespace HoopMetrics.Models;

public class PerformanceStats
{
    public int PointsScored { get; set; }
    public int Assists { get; set; }
    public int Rebounds { get; set; }
    public double PerformanceRating => (PointsScored + Assists * 0.7 + Rebounds * 0.7) / 3;
}