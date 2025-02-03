# Lagerverwaltungsprogramm

## Übersicht
Ein einfaches Lagerverwaltungsprogramm, das es ermöglicht, Artikel zu verwalten, Bestände zu überwachen und Berichte zu generieren. Das Programm bietet eine Benutzeroberfläche zur Verwaltung von Artikeln, Lagerplätzen und Benutzerrechten.

## Hauptfunktionen

1. **Artikel hinzufügen**:
   - Ermöglicht das Hinzufügen von Artikeln mit Artikelnummer, Name, Beschreibung, Menge und Preis.
   
2. **Artikel bearbeiten**:
   - Änderung von Artikeldaten wie Name, Beschreibung, Menge und Preis.

3. **Artikel löschen**:
   - Entfernen von Artikeln aus dem System.

4. **Bestandsübersicht**:
   - Anzeige aller Artikel mit Optionen zum Filtern und Sortieren.
   - Markierung von Artikeln mit niedrigen Beständen (z.B. Menge ≤ 3).
   
5. **Bestand aktualisieren**:
   - Erhöhung oder Verringerung der Artikelmenge bei Wareneingang oder -ausgang.

6. **Statistik**:
   - Erzeugung von Statistiken, z.B. die häufigsten Artikel im Lager.

7. **Lagerplatzverwaltung** (Zusatz):
   - Verwaltung mehrerer Lagerplätze für Artikel.

8. **Benutzerverwaltung** (Zusatz):
   - Verwaltung von mehreren Benutzern mit unterschiedlichen Zugriffsrechten.

## Technische Details

- **Programmiersprache**: C# mit ASP.NET Core und Blazor
- **Datenbank**: SQL-basierte Datenbank (z.B. SQL Server, SQLite)
- **Benutzeroberfläche**: Interaktive Weboberfläche mit Blazor (Razor Pages)
- **Fehlerbehandlung**: Eingabefehler und andere Fehler werden durch Validierung und Fehlernachrichten behandelt.

## Erweiterungen (Optional)

- **Mehrere Lagerplätze**: Ermöglicht die Verwaltung von Artikeln an unterschiedlichen Lagerorten.
- **Benutzerrechte**: Einrichtbar für verschiedene Benutzerrollen (Admin, Standardbenutzer).



<img src="img/dbdiagram.png" width="500px" />
Table Lagerplatz {
  id integer [primary key]
  name varchar
  standort varchar 
}

Table Artikel {
  id integer [primary key]
  artikelname varchar
  beschreibung varchar
  menge integer
  preis float
  lager_id integer
}



Ref: Artikel.lager_id > Lagerplatz.id // many-to-one

