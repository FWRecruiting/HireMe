namespace HireMeApi.Domain.Models;

public class IotDevice
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }

    public IotDevice(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}
