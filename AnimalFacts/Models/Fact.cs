using System.ComponentModel.DataAnnotations;

namespace AnimalFacts.Models
{
  public class Fact
  {
    public int FactId { get; set; }
    [Required]
    public string AnimalType { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Description { get; set; }
  
    public string Nsfw { get; set; }
  }
}