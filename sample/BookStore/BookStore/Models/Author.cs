namespace BookStore.Models;

public class Author(string name, string emailAddress)
{
    public string Name { get; set; } = name;

    public string EmailAddress { get; set; } = emailAddress;
}