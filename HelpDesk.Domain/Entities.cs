namespace HelpDesk.Domain.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = "Customer";
    
}

public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DateOpenCall { get; set; } = DateTime.Now;
    public DateTime? DateCloseCall { get; set; }
    public string Status { get; set; } = "Open";
    public string Priority { get; set; } = "Medium";

    public int CustomerId { get; set; }
    public User Customer { get; set; } = null!;
    public int? TecnicianId { get; set; }
    public User? Tecnician { get; set; }
}