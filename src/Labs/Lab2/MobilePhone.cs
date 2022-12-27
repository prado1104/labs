namespace Lab2;

public class MobilePhone
{
    public MobilePhone(string name, string communicationStandard, decimal price, int batteryCapacity)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        
        if (price < 0)
            throw new ArgumentException("Price cannot be negative", nameof(price));

        if (batteryCapacity < 0)
            throw new ArgumentException("Battery capacity cannot be negative", nameof(batteryCapacity));
        
        Price = price;
        CommunicationStandard = communicationStandard;
        BatteryCapacity = batteryCapacity;
    }
    
    /// <summary>
    /// Название модели мобильного телефона
    /// </summary>
    public string Name { get; }
    
    /// <summary>
    /// Стандарт связи
    /// </summary>
    public string CommunicationStandard { get; }
    
    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal Price { get; }
    
    /// <summary>
    /// Уровень заряда акуумулятора
    /// </summary>
    public int BatteryCapacity { get; }

    public override string ToString()
    {
        return $"{Name} ({CommunicationStandard}) - {Price} руб. ({BatteryCapacity}%)";
    }
}