using System.ComponentModel.DataAnnotations;

namespace Lagerverwaltung.Models;

public class Lagerplatz
{
    [Key]
    public int LagerplatzId { get; set; } // Primärschlüssel
    public string Name { get; set; } = string.Empty;
    public string Standort { get; set; } = string.Empty;
}
