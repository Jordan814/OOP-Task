namespace Exam_Prep_ООП.Models.Products.Components;

public class VideoCard : Component
{
    private const double VideoCardMultiplier = 1.20;
    
    public VideoCard(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance, generation)
    {
        this.OverallPerformance *= VideoCardMultiplier;
    }
}