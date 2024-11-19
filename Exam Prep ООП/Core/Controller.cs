using Exam_Prep_ООП.Models.Products.Components;
using Exam_Prep_ООП.Models.Products.Computers;
using Exam_Prep_ООП.Models.Products.Peripherals;

namespace Exam_Prep_ООП.Core;

public class Controller : IController
{
    private readonly IList<IComputer> _computers;
    private readonly IList<IComponent> _components;
    private readonly IList<IPeripheral> _peripherals;

    public Controller()
    {
        this._computers = new List<IComputer>();
        this._components = new List<IComponent>();
        this._peripherals = new List<IPeripheral>();
    }
    
    public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
    {
        if (this._computers.Any(x => x.Id == id))
        {
            throw new ArgumentException("Computer with this Id already exists.");
        }

        IComputer computer = null;
        
        if (computerType == "Laptop")
        {
            computer = new Laptop(id, manufacturer, model, price);
        }
        else if (computerType == "DesktopComputer")
        {
            computer = new DesktopComputer(id, manufacturer, model, price);
                    
        }
        else
        {
            throw new ArgumentException("Computer type is not valid.");
        }
        
        this._computers.Add(computer);
        
        return $"Computer with id {id} added successfully.";
    }

    public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price,
        double overallPerformance, string connectionType)
    {
        DoesComputerExists(computerId);

        if (this._peripherals.Any(x => x.Id == id))
        {
            throw new ArgumentException("Peripheral with this id already exists.");
        }

        IPeripheral peripheral = null;

        if (peripheralType == "HeadSet")
        {
            peripheral = new HeadSet(id, manufacturer, model, price, overallPerformance, connectionType);
        }
        else if (peripheralType == "KeyBoard")
        {
            peripheral = new KeyBoard(id, manufacturer, model, price, overallPerformance, connectionType);

        }
        else if (peripheralType == "Monitor")
        {
            peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);

        }
        else if (peripheralType == "Mouse")
        {
            peripheral = new Mouse(id, manufacturer, model, price, overallPerformance, connectionType);

        }
        else
        {
            throw new ArgumentException("Peripheral type is invalid.");
        }
        
        this._computers.FirstOrDefault(x => x.Id == computerId).AddPeripheral(peripheral);
        
        this._peripherals.Add(peripheral);
        
        return $"Peripheral {peripheralType} with id {id} added successfully in computer with id {computerId}.";
    }

    public string RemovePeripheral(string peripheralType, int computerId)
    {
        DoesComputerExists(computerId);

        var peripheral = this._computers.FirstOrDefault(x => x.Id == computerId).RemovePeripheral(peripheralType);
        
        
        return $"Successfully removed {peripheralType} with id {peripheral.Id}";
    }


    
    public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price,
        double overallPerformance, int generation)
    {
        DoesComputerExists(computerId);

        if (this._components.Any(x => x.Id == id))
        {
            throw new ArgumentException("Component with this id already exists.");
        }

        IComponent component = null;

        if (componentType == "CentralProcessUnit")
        {
            component = new CentralProcessUnit(id, manufacturer, model, price, overallPerformance, generation);
        }
        else if (componentType == "MotherBoard")
        {
            component = new MotherBoard(id, manufacturer, model, price, overallPerformance, generation);

        }
        else if (componentType == "PowerSupply")
        {
            component = new PowerSupply(id, manufacturer, model, price, overallPerformance, generation);

        }
        else if (componentType == "RandomAccessMemory")
        {
            component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance, generation);

        }
        else if (componentType == "SolidStateDrive")
        {
            component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance, generation);

        }
        else if (componentType == "VideoCard")
        {
            component = new VideoCard(id, manufacturer, model, price, overallPerformance, generation);

        }
        else
        {
            throw new ArgumentException("Component type is invalid");
        }
        
        this._components.Add(component);
        
        this._computers.FirstOrDefault(x => x.Id == computerId).AddComponent(component);
        
        return $"Component {componentType} with id {id} added successfully in computer with id {computerId}.";
    }

    public string RemoveComponent(string componentType, int computerId)
    {
        DoesComputerExists(computerId);

        var component =  this._computers.FirstOrDefault(x => x.Id == computerId).RemoveComponent(componentType);

        return $"Successfully remover {componentType} with id {component.Id}.";
    }

    public string BuyComputer(int id)
    {
        DoesComputerExists(id);

        var computer = this._computers.FirstOrDefault(x => x.Id == id);
        
        this._computers.Remove(computer);

        return computer.ToString();
    }

    public string BuyBest(decimal budget)
    {

        var topComputer = _computers.Where(x => x.Price <= budget)
            .OrderByDescending(x => x.OverallPerformance).FirstOrDefault();
        
        if (topComputer == null)
        {
            throw new ArgumentException($"Can't buy a computer with a budget of{budget}");
        }
        
        this._computers.Remove(topComputer);

        return topComputer.ToString();
    }

    public string GetComputerData(int id)
    {
        DoesComputerExists(id);

        var computer = this._computers.FirstOrDefault(x => x.Id == id);
        
        return computer.ToString();
    }
    
    private void DoesComputerExists(int id)
    {
        if(!this._computers.Any(x => x.Id == id))
        {
            throw new ArgumentException("Computer with this id does not exist.");
        }

    }
}