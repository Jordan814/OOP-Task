using Exam_Prep_ООП.Models.Products.Components;
using Exam_Prep_ООП.Models.Products.Peripherals;

namespace Exam_Prep_ООП.Models.Products.Computers;

public interface IComputer : IProduct
{
    IReadOnlyCollection<IComponent> Components { get; }

    IReadOnlyCollection<IPeripheral> Peripherals { get; }

    void AddComponent(IComponent component);

    IComponent RemoveComponent(string componentType);

    void AddPeripheral(IPeripheral peripheral);

    IPeripheral RemovePeripheral(string peripheralType);
}