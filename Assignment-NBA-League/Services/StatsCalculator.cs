namespace HoopMetrics.Services;

public class StatsCalculator : IStatsCalculator
{
    public double CalculatePerformanceRating(int points, int assists, int rebounds)
    {
        return (points + assists * 0.7 + rebounds * 0.7) / 3;
    }

    public double CalculateEfficiency(int points, int assists, int rebounds, int minutesPlayed)
    {
        if (minutesPlayed == 0) return 0;
        return (points + assists + rebounds) / (double)minutesPlayed;
    }
}