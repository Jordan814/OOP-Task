namespace Exam_Prep_ООП.Models.Products.Components;

public class CentralProcessUnit : Component
{
    private const double CentralProcessUnitMultiplier = 1.25;
    public CentralProcessUnit(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation)
        : base(id, manufacturer, model, price, overallPerformance, generation)
    {
        this.OverallPerformance *= CentralProcessUnitMultiplier;
    }
}