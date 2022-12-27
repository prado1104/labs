using Lab2;

Console.WriteLine("Загружаем данные из файла...");

var fileName = "data.txt";

var phones = ReadFromFile(fileName);
foreach (var phone in phones) 
    Console.WriteLine(phone);

while (true)
{
    Console.Write("Введите цену, чтобы найти телефоны с ценой меньшей или равной заданной: ");
    var priceText = Console.ReadLine();

    if (!decimal.TryParse(priceText, out var price))
    {
        Console.WriteLine("Некорректный ввод");
        continue;
    }
    
    var foundPhone = phones.Where(p => p.Price <= price).ToList();
    if (foundPhone.Count == 0)
    {
        Console.WriteLine("Телефоны не найдены");
        continue;
    }
    
    foreach (var phone in foundPhone)
        Console.WriteLine(phone);
}

MobilePhone[] ReadFromFile(string fileName)
{
    var result = new List<MobilePhone>();
    foreach (var line in File.ReadAllLines(fileName)) 
        result.Add(CreateMobilePhone(line));

    return result.ToArray();

    MobilePhone CreateMobilePhone(string line)
    {
        var splitted = line.Split(";");
        
        decimal.TryParse(splitted[2], out var price);
        int.TryParse(splitted[3], out var batteryCapacity);
        
        return new MobilePhone(splitted[0], splitted[1], price, batteryCapacity);
    }
}