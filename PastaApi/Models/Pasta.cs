using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastaApi.Models
{
  public class Pasta
  {
    public int PastaId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string NoodleType { get; set; }
    [Required]
    public bool GlutenFree { get; set; }
    public string SauceType { get; set; }
    public List<string> Ingredients { get; set; }
    [Required]
    public string Origin { get; set; }
    public string Url { get; set; }
    [Required]
    public string ImageUrl { get; set; }
  }
}

