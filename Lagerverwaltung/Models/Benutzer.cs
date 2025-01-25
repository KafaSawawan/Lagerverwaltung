using System.ComponentModel.DataAnnotations;

namespace Lagerverwaltung.Models;

public class Benutzer
{
    [Key]
    public int BenutzerId { get; set; } // Primärschlüssel
    public string Name { get; set; } = string.Empty;
    public string Rolle { get; set; } = string.Empty;
    public string Passwort { get; set; } = string.Empty;
}
