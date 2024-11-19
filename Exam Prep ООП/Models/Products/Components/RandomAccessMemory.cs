namespace Exam_Prep_ООП.Models.Products.Components;

public class RandomAccessMemory : Component
{
    private const double RandomAccessMemoryMultiplier = 1.20;

    public RandomAccessMemory(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance, generation)
    {
        this.OverallPerformance *= RandomAccessMemoryMultiplier;
    }
}