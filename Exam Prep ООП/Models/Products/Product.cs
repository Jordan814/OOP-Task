using Exam_Prep_ООП.Common.Constants;

namespace Exam_Prep_ООП.Models.Products;

public abstract class Product : IProduct
{
    private int id;
    private string manufacturer;
    private string model;
    private decimal price;
    private double overallPerformance;


    public Product(int id, string manufacturer, string model, decimal price, double overallPerformance)
    {
        this.Id = id;
        this.Manufacturer = manufacturer;
        this.Model = model;
        this.Price = price;
        this.OverallPerformance = overallPerformance;

    }

    public int Id
    {
        get
        {
            return this.id;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ExceptionMessages.InvalidProductId);
            }

            this.id = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.InvalidManufacturer);
            }

            this.manufacturer = value;
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ExceptionMessages.InvalidModel);
            }

            this.model = value;
        }
    }

    public virtual decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPrice);
            }

            this.price = value;
        }
    }

    public virtual double OverallPerformance
    {
        get
        {
            return this.overallPerformance;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ExceptionMessages.InvalidOverallPerformance);
            }

            this.overallPerformance = value;
        }
    }

    public override string ToString()
    {
        return string.Format(SuccessMessages.ProductToString,
            this.overallPerformance,
            this.price,
            this.GetType().Name,
            this.manufacturer,
            this.model,
            this.id);
    }
}