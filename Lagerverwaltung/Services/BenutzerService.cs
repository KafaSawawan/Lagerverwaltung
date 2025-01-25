using Lagerverwaltung.Models;

namespace Lagerverwaltung.Services;

public class BenutzerService
{
    private readonly List<Benutzer> _benutzerListe = new()
    {
        new Benutzer { BenutzerId = 1, Name = "Admin", Rolle = "Admin", Passwort = "admin123" },
        new Benutzer { BenutzerId = 2, Name = "User", Rolle = "Nutzer", Passwort = "user123" }
    };

    public Benutzer? Login(string name, string passwort)
    {
        return _benutzerListe.FirstOrDefault(b => b.Name == name && b.Passwort == passwort);
    }
}
