namespace Exam_Prep_ООП.Models.Products.Peripherals;

public class HeadSet : Peripheral
{
    public HeadSet(int id, string manufacturer, string model, decimal price, double overallPerformance, string connectionType)
        : base(id, manufacturer, model, price, overallPerformance, connectionType)
    {
    }
}