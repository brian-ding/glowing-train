namespace BookStore.Models;

public class Publisher(Guid id, string name, string address)
{
    public Guid Id { get; set; } = id;

    public string Name { get; set; } = name;

    public string Address { get; set; } = address;
}