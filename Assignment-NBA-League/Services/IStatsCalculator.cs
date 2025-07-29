namespace HoopMetrics.Services;

public interface IStatsCalculator
{
    double CalculatePerformanceRating(int points, int assists, int rebounds);
    double CalculateEfficiency(int points, int assists, int rebounds, int minutesPlayed);
}