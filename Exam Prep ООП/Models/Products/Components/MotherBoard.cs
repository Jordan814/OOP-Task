namespace Exam_Prep_ООП.Models.Products.Components;

public class MotherBoard : Component
{
    private const double MotherBoardMultiplier = 1.25;

    public MotherBoard(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation) : base(id, manufacturer, model, price, overallPerformance, generation)
    {
        this.OverallPerformance *= MotherBoardMultiplier;
    }
}