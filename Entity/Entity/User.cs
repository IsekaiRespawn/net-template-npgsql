using System.ComponentModel.DataAnnotations;

namespace Entity;

public class User
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;

}
