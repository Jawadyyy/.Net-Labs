namespace HoopMetrics.Models;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public string Nationality { get; set; }

    public string ImageUrl { get; set; }
    public PerformanceStats PerformanceStats { get; set; }
    public FitnessStats FitnessStats { get; set; }
    public InjuryStats InjuryStats { get; set; }
}