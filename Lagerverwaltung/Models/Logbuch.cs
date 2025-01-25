using System.ComponentModel.DataAnnotations;

namespace Lagerverwaltung.Models;

public class Logbuch
{
    [Key]
    public int LogId { get; set; } // Primärschlüssel
    public int Artikelnummer { get; set; } // FK
    public int BenutzerId { get; set; } // FK
    public DateTime Datum { get; set; }
    public string Aktion { get; set; } = string.Empty; // "Hinzufügen", "Bearbeiten", "Löschen"
    public int Menge { get; set; }
}
