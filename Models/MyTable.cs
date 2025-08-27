using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("NetflixDataset")] // Table name with space
[Keyless]
public class MyTable
{
    public string Show_Id { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public string? Director { get; set; }
    public string? Cast { get; set; }
    public string? Country { get; set; }
    public DateTime? Release_Date { get; set; }
    public string? Rating { get; set; }
    public string Duration { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }

    // Add other properties matching your table columns
}
