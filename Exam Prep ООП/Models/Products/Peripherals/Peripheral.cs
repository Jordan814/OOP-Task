using Exam_Prep_ООП.Common.Constants;

namespace Exam_Prep_ООП.Models.Products.Peripherals;

public abstract class Peripheral : Product,IPeripheral
{
    public Peripheral(int id, string manufacturer, string model, decimal price, double overallPerformance,string connectionType)
        : base(id, manufacturer, model, price, overallPerformance)
    {
        this.ConnectionType = connectionType;
    }

    public string ConnectionType { get; }
    
    public override string ToString()
    {
        return base.ToString() + string.Format(SuccessMessages.PeripheralToString, this.ConnectionType);
    }
}