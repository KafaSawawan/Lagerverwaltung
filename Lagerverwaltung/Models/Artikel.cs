
using System.ComponentModel.DataAnnotations;

namespace Lagerverwaltung.Models;

public class Artikel
{
    [Key]

    public int ArtikelId { get; set; }
    public string Artikelname { get; set; } = string.Empty;
    public string Beschreibung { get; set; } = string.Empty;
    public int Menge { get; set; }
    public decimal PreisProEinheit { get; set; }
    // Lagerplatz-Zuordnung
    public int LagerplatzId { get; set; }
    public Lagerplatz Lagerplatz { get; set; }
}
