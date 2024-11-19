using Exam_Prep_ООП.Common.Constants;

namespace Exam_Prep_ООП.Models.Products.Components;

public abstract class Component : Product, IComponent
{

    protected Component(int id, string manufacturer, string model, decimal price, double overallPerformance,int generation)
        : base(id, manufacturer, model, price, overallPerformance)
    {
        this.Generation = generation;
    }

    public int Generation { get; }

    public override string ToString()
    {
        return base.ToString() + string.Format(SuccessMessages.ComponentToString, this.Generation);
    }
}